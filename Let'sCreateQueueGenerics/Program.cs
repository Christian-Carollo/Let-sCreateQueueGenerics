
using Let_sCreateQueueGenerics;

ConsoleLogger consoleLogger = new ConsoleLogger();

MyQueue<double> queueList = new MyQueue<double>(consoleLogger);

MyQueue<int> intQueueList = new IntQueue(consoleLogger);

MyQueue<string> stringQueueList = new StringQueue(consoleLogger);


queueList.Enqueue(1.1);
queueList.Enqueue(2.2);
queueList.Enqueue(3.3);
queueList.Enqueue(4.4);
queueList.Print();

queueList.Peek();

queueList.Dequeue();
queueList.Print();

Console.WriteLine("-------------------------------------------------------------------------------\n IntQueueList:\n");

intQueueList.Enqueue(10);
intQueueList.Enqueue(20);
intQueueList.Enqueue(30);
intQueueList.Enqueue(40);

intQueueList.Print();

intQueueList.Peek();

intQueueList.Dequeue();
intQueueList.Print();

Console.WriteLine("-------------------------------------------------------------------------------\n StringQueueList:\n");

stringQueueList.Enqueue("100");
stringQueueList.Enqueue("200");
stringQueueList.Enqueue("300");
stringQueueList.Enqueue("400");

stringQueueList.Print();

stringQueueList.Peek();

stringQueueList.Dequeue();
stringQueueList.Print();