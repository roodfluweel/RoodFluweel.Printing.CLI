using RoodFluweel.Printing.Model;

public partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("****************************************");
        Console.WriteLine("RoodFluweel PDF PrintTool by Reprise vzw");
        Console.WriteLine("****************************************");

        ServiceBus.ReceiveMessages((ticketBundle) =>
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
        Console.WriteLine("Printing ticket for customer: " + body.Customer.FullName);
    }
}

