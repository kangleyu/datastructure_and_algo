using NUnit.Framework;
using System.Collections.Generic;

namespace DataStructure.Tests
{
    [TestFixture]
    public class LinkedListFixture
    {
        [Test]
        public void Generate_LinkedList_From_List()
        {
            LinkedList<int> llist = new LinkedList<int>(new List<int> { 1, 2, 3, 4, 5, 6 });
            Assert.AreEqual("1 => 2 => 3 => 4 => 5 => 6  \r\n", llist.ToString());
        }

        [Test]
        public void Generate_LinkedList_From_Array()
        {
            LinkedList<int> llist = new LinkedList<int>(1, 2, 3, 4, 5, 6);
            Assert.AreEqual("1 => 2 => 3 => 4 => 5 => 6  \r\n", llist.ToString());
        }

        [Test]
        public void Initialized_LinkedList_Should_Be_Empty()
        {
            LinkedList<int> llist = new LinkedList<int>();
            Assert.IsNull(llist.Root);
        }
    }
}
