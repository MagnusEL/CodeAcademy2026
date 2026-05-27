
using Consumer.ConsumerFactory;

Console.WriteLine("Starting Consumer application...");

var consumer = await ConsumerFactory.CreateConsumer();

// Implement a basic consumer here.
// Start with:
// - Create a channel
// - Declare a queue
// - Create a consumer and subscribe to the queue
// - Handle incoming messages by deserializing the JSON and printing the content to the console

Console.ReadLine();