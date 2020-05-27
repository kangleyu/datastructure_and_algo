using NUnit.Framework;

namespace DataStructure.Tests
{
    [TestFixture]
    public class QueueFixtures
    {
        [Test]
        public void Initialize_New_Queue_Should_Return_Empty_Queue()
        {
            IQueue<int> queue = new Queue<int>();
            Assert.IsTrue(queue.IsEmpty());
        }

        [Test]
        public void Add_Item_Into_Queue_Should_Be_Able_To_Peek_And_Popup()
        {
            IQueue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Assert.AreEqual(5, queue.Count);
            Assert.AreEqual(1, queue.Peek());
            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(14);
            queue.Enqueue(15);
            queue.Enqueue(16);
            queue.Enqueue(17);
            Assert.AreEqual(3, queue.Dequeue());
            Assert.AreEqual(4, queue.Dequeue());
            Assert.AreEqual(5, queue.Dequeue());
            Assert.AreEqual(6, queue.Dequeue());
            Assert.AreEqual(7, queue.Dequeue());
            Assert.AreEqual(8, queue.Dequeue());
            Assert.AreEqual(9, queue.Dequeue());
            Assert.AreEqual(10, queue.Dequeue());
            Assert.AreEqual(11, queue.Dequeue());
            Assert.AreEqual(12, queue.Dequeue());
            Assert.AreEqual(13, queue.Dequeue());
            Assert.AreEqual(14, queue.Dequeue());
            Assert.AreEqual(15, queue.Dequeue());
            Assert.AreEqual(16, queue.Dequeue());
            Assert.AreEqual(17, queue.Dequeue());
        }
    }
}
