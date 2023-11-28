
using Let_sCreateQueueGenerics;

MyQueue<int> queueList = new MyQueue<int>();


queueList.Enqueue(1);
queueList.Enqueue(2);
queueList.Enqueue(3);
queueList.Enqueue(4);
queueList.Print();

queueList.Peek();

queueList.Dequeue();
queueList.Print();