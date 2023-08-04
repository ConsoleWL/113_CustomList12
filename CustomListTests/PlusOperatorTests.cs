using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    [TestClass]
    public class PlusOperatorTests
    {
        [TestMethod]
        public void PlusOperator_FirstListIsLongerThanSecondOne_ReturnTrue()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            one.Add(1);
            one.Add(2);
            one.Add(3);
            CustomList<int> two = new CustomList<int>();
            two.Add(4);
            two.Add(5);
            CustomList<int> three = one + two;
            bool result = false;

            //Set
            if (three[0] == one[0] && three[1] == one[1] && three[2] == one[2] && three[3] == two[0] && three[4] == two[1])
            {
                result = true;
            }

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PlusOperator_SecondListIsLongerThanTheFirstList()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            one.Add(1);
            one.Add(2);
            CustomList<int> two = new CustomList<int>();
            two.Add(3);
            two.Add(4);
            two.Add(5);
            bool result = false;
            //Set
            result = two.Count > one.Count;

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PlusOperator_IfOneListisEmptyResultsUnchanged_ReturnTrue()
        {
            //Arrange
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            CustomList<int> numbers2 = new CustomList<int>();
            bool result = false;

            //Set
            CustomList<int> numbers3 = numbers + numbers2;

            result = numbers.Count == numbers3.Count;

            //Assert
            Assert.IsTrue(result);
        }



    }
}
