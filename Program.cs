using Newtonsoft.Json;
using RoodFluweel.Printing.BL.Pdf;
using RoodFluweel.Printing.Model;

public partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("****************************************");
        Console.WriteLine("RoodFluweel PDF PrintTool by Reprise vzw");
        Console.WriteLine("****************************************");

        // Force Skia rendering engine (cross-platform) for DevExpress, instead of GDI+
        DevExpress.Drawing.Internal.DXDrawingEngine.ForceSkia();

        // Get servicebus connection string from config.json file
        string connectionString = "";
        string queueName = "";
        try {
            string json = File.ReadAllText("config.json");
            dynamic config = JsonConvert.DeserializeObject(json);
            if (config == null || config?.ServiceBus == null || config?.ServiceBus?.ConnectionString == null || config?.ServiceBus?.QueueName == null) {
                throw new Exception("config.json is empty or invalid");
            }
            connectionString = config.ServiceBus.ConnectionString;
            queueName = config.ServiceBus.QueueName;
        } catch (Exception e) {
            Console.WriteLine("Error reading config.json: " + e.Message);
            return;
        }

        ServiceBus.ReceiveMessages(connectionString, queueName, (ticketBundle) =>
        {
            // Process the received message
            Console.WriteLine($"Received TicketBundle for Customer: {ticketBundle.Customer.FullName}");
            OnMessageArrived(ticketBundle);
            return Task.CompletedTask;
        });

        Console.WriteLine("Waiting for messages on bus... Press Ctrl+C to quit.");

        while(true) {
            System.Threading.Thread.Sleep(100);
        }
    }

    private static void OnMessageArrived(TicketBundle body)
    {
        Console.WriteLine("Received new TicketBundle: " + body.BundleId);

        Printer printer = new Printer();

        // Load XML template
        string cwd = Directory.GetCurrentDirectory();
        printer.TemplatePath = cwd + "/Templates/reprise_qr_xml.repx";

        // Generate PDF filename based on date + time + fullName
        string pdfFilename = cwd + "/Output/" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + body.Customer.FullName + ".pdf";

        // Create directory if it doesn't exist
        Directory.CreateDirectory(cwd + "/Output");

        printer.GetPdf(body, pdfFilename);
    }
}

