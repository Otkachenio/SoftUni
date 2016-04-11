using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SinglyLinkedListProject;

namespace SiglyLinkedListTests
{
    [TestClass]
    public class SynglyLinkedListTest
    {
        [TestMethod]
        public void Test_CreatingNewLinkedList_ShouldReturnNonNullEmptyLinkedList()
        {
            var list = new SinglyLinkedList();

            Assert.IsNotNull(list);
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void Test_AppendingSingleItemToEmptyList_ShouldReturnTheItemAndListCountOfOne()
        {
            int testNumber = 5;
            var list = new SinglyLinkedList();

            list.Append(testNumber);

            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void Test_AppendingSingleItemToEmptyList_ShouldReturnTheItemAndCountOfOne()
        {
            int testNumber = 5;
            var list = new SinglyLinkedList();

            list.Append(testNumber);

            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void Test_AppendingManyItemToEmptyList_ShouldReturnTheItemAndTheCorrectCount()
        {
            int[] testNumbers = new[] { 1, 3, 5, 7 };
            var list = new SinglyLinkedList();

            list.Append(testNumbers[0]);
            list.Append(testNumbers[1]);
            list.Append(testNumbers[2]);
            list.Append(testNumbers[3]);

            Assert.AreEqual(testNumbers.Length, list.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Deletin From empty list is not possible.")]
        public void Test_DeletingItemFromEmptyList_ShouldThrowException()
        {
            var list = new SinglyLinkedList();

            list.Delete("ERROR");
        }

        [TestMethod]
        public void Test_DeletingItemFromList_WithOneItem_ShouldReturnEmptyList()
        {
            string test = "Test string";
            var list = new SinglyLinkedList();
            list.Append(test);

            list.Delete(test);

            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void Test_DeleteManyItemFromList_ShouldReturnTheRestOfTheItems()
        {
            int[] testNumbers = new[] { 1, 3};
            int firstNum = 5;
            int secondNum = 10;
            var list = new SinglyLinkedList();
            list.Append(testNumbers[0]);
            list.Append(testNumbers[1]);
            list.Append(firstNum);
            list.Append(secondNum);

            list.Delete(firstNum);
            list.Delete(secondNum);

            Assert.AreEqual(testNumbers.Length, list.Count);
        }
    }
}