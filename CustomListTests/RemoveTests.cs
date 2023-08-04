﻿using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void Remove_CountDecremeantingWhenItemAdded_ReturnTrue()
        {
            // Arange
            CustomList<string> names = new CustomList<string>();
            names.Add("Tom");
            names.Add("Bob");
            names.Add("Bob");
            names.Add("Bob");
            int countBeforeRemove = names.Count;
            int countAfterRemove;

            // Set
            names.Remove("Tom");
            countAfterRemove = names.Count;

            // Assert
            Assert.IsTrue(countBeforeRemove > countAfterRemove);
        }

        [TestMethod]
        public void Remove_WhenItemRemovedSuccesfuly_ReturnTrue()
        {
            // Arange
            CustomList<string> names = new CustomList<string>();
            names.Add("Tom");
            names.Add("Bob");
            names.Add("Tom");
            bool result = false;
            //Set
            result = names.Remove("Bob");
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Remove_CountDoesNotDecrementIfCouldNotRemoveItem_CountStaysTheSame()
        {
            // Arrange
            CustomList<string> names = new CustomList<string>();
            names.Add("Bob");
            names.Add("Bob");
            names.Add("Bob");
            int countBeforeRemoving = names.Count;

            // Set
            names.Remove("Tom");
            int countAfterRemoving = names.Count;

            // Assert
            Assert.AreEqual(3, names.Count);
        }

        [TestMethod]
        public void Remove_ItemsShiftBackwardsAfterRemovingOneItem_IndexOneEqualsIndexTwo()
        {
            //Arrange
            CustomList<string> names = new CustomList<string>();
            names.Add("Nikita");
            names.Add("Bob");
            names.Add("Tom");

            //Set
            names.Remove("Nikita");

            //Assert
            Assert.AreEqual(names[1], "Tom");
        }

        [TestMethod]
        public void Remove_RemoveOnlyFirstItemWithTheSameName_ReturnTrue()
        {
            //Arrange
            CustomList<string> names = new CustomList<string>();
            names.Add("Bob");
            names.Add("Bob");
            names.Add("Bob");
            bool result1 = false;


            //Set
            names.Remove("Bob");
            if (names[0] == "Bob" && names[1] == "Bob")
            {
                result1 = true;
            }


            //Assert
            Assert.IsTrue(result1);
        }
    }
}