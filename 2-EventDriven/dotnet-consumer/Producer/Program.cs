

using Producer;

Console.WriteLine("Producer starting...");
// Establish connection to RabbitMQ

// Implement a basic producer here.
// Start with:
// - Create a channel
// - Declare a queue
// - Publish a message to the queue (you can use a simple JSON string as the message body)

await MessageSimulator.CreateSimulator(3);