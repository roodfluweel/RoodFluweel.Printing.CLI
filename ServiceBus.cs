using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.InteropExtensions;
using RoodFluweel.Printing.Model;

public class ServiceBus
{
    static QueueClient? queueClient;

    public static void ReceiveMessages(string ConnectionString, string QueueName, Func<TicketBundle, Task> messageHandler)
    {
        // Initialize the queue client
        queueClient = new QueueClient(ConnectionString, QueueName);

        // Register the message handler and receive messages in a loop
        queueClient.RegisterMessageHandler(async (message, token) =>
        {
            TicketBundle tb = MessageInteropExtensions.GetBody<TicketBundle>(message);
            await messageHandler(tb);

            // Complete the message so that it is not received again
            await queueClient.CompleteAsync(message.SystemProperties.LockToken);
        },
        new MessageHandlerOptions(args =>
        {
            // Handle any exceptions
            Console.WriteLine($"Exception: {args.Exception}");
            return Task.CompletedTask;
        })
        {
            MaxConcurrentCalls = 1,
            AutoComplete = false // We'll manually complete the message after processing
        }
        );
    }

    public static async Task StopReceivingMessagesAsync()
    {
        // Close the queue client
        if (queueClient != null) {
            await queueClient.CloseAsync();
        }
    }
}
