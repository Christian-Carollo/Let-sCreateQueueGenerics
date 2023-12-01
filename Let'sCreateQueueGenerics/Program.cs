
using Let_sCreateQueueGenerics;

MyQueue<int> queueList = new MyQueue<int>();

MyQueue<int> intQueueList = new IntQueue();

MyQueue<string> stringQueueList = new StringQueue();


queueList.Enqueue(1);
queueList.Enqueue(2);
queueList.Enqueue(3);
queueList.Enqueue(4);
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
