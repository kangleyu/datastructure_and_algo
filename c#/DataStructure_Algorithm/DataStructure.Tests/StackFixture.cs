using NUnit.Framework;

namespace DataStructure.Tests
{
    [TestFixture]
    public class StackFixture
    {
        [Test]
        public void Initialized_Stack_Should_Be_Empty()
        {
            Stack<int> stack = new Stack<int>();
            Assert.IsTrue(stack.IsEmpty());
            Assert.AreEqual(0, stack.Count);
        }

        [Test]
        public void Push_And_Pop_On_Stack_Should_Keep_The_Correct_State()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Assert.IsFalse(stack.IsEmpty());
            Assert.AreEqual(5, stack.Count);

            Assert.AreEqual(5, stack.Peek());
            Assert.AreEqual(5, stack.Pop());
            Assert.AreEqual(4, stack.Pop());
            Assert.AreEqual(3, stack.Pop());
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);
            stack.Push(15);
            stack.Push(16);
            stack.Push(17);
            stack.Push(18);
            stack.Push(19);
            stack.Push(20);
            Assert.AreEqual(20, stack.Peek());
            Assert.AreEqual(20, stack.Pop());
            Assert.AreEqual(19, stack.Pop());
            Assert.AreEqual(18, stack.Pop());
            Assert.AreEqual(17, stack.Pop());
            Assert.AreEqual(16, stack.Pop());
            Assert.AreEqual(15, stack.Pop());
            Assert.AreEqual(14, stack.Pop());
            Assert.AreEqual(13, stack.Pop());
            Assert.AreEqual(12, stack.Pop());
            Assert.AreEqual(11, stack.Pop());
            Assert.AreEqual(10, stack.Pop());
            Assert.AreEqual(9, stack.Pop());
            Assert.AreEqual(8, stack.Pop());
            Assert.AreEqual(7, stack.Pop());
            Assert.AreEqual(6, stack.Pop());
            Assert.AreEqual(2, stack.Pop());
        }
    }
}
