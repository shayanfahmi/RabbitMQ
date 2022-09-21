using RabbitMQ.Client;
using System;
using System.Text;

namespace Producer
{
    public class Sender
    {
        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" }; // Create a factory
            using (var connection = factory.CreateConnection()) //Open a connection
            using (var channel = connection.CreateModel()) //Open a channel
            {
                channel.QueueDeclare("BasicTest", false, false, false, null); //Declare the queue

                string message = "Getting started with .Net Core RabbitMQ";
                var body = Encoding.UTF8.GetBytes(message); //Create a message
                
                channel.BasicPublish("", "BasicTest", null, body); //Publish a message
                Console.WriteLine("Sent message {0}...", message);
            }

            Console.WriteLine("Press [enter] to exit the Sender App...");
            Console.ReadLine();
        }
    }
}
