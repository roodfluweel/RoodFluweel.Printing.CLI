using Newtonsoft.Json;
using RoodFluweel.Printing.BL.Pdf;
using RoodFluweel.Printing.Model;

public partial class Program
{
    private static string templatePath = "";

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
            var config = JsonConvert.DeserializeObject<Config>(json);
            if (config?.ServiceBus?.ConnectionString == null ||
                config?.ServiceBus?.QueueName == null ||
                config?.TemplatePath == null) {
                throw new Exception("config.json is empty or invalid");
            }
            connectionString = config.ServiceBus.ConnectionString;
            queueName = config.ServiceBus.QueueName;
            templatePath = config.TemplatePath;
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
        printer.TemplatePath = Path.Combine(cwd, templatePath);

        // Generate PDF filename based on date + time + fullName
        string pdfFilename = cwd + "/Output/" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + body.Customer.FullName + ".pdf";

        // Create directory if it doesn't exist
        Directory.CreateDirectory(cwd + "/Output");

        printer.GetPdf(body, pdfFilename);
    }
}

public class Config
{
    public ServiceBusConfig? ServiceBus { get; set; }
    public string? TemplatePath { get; set; }
}

public class ServiceBusConfig
{
    public string? ConnectionString { get; set; }
    public string? QueueName { get; set; }
}

