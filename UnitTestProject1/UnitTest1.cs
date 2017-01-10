using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        List<Record> records = new List<Record>();

        public static List<Record> GetTestData()
        {
            return new List<Record>(){
                new Record { ID = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new Record { ID = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new Record { ID = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new Record { ID = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new Record { ID = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new Record { ID = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new Record { ID = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new Record { ID = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new Record { ID = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new Record { ID = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new Record { ID = 11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };

        }
        [TestMethod]
        public void 測試取三個值()
        {

            //arrange
            var target = new Calculator();
            var expected = new int[] { 6, 15, 24, 21 };
            var demand = new Demand { groupnum = "3", col = "COST" };
            //act

            var actual = target.AddRecord(demand, GetTestData());

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
        public void 測試取四個值()
        {
            //arrange
            var target = new Calculator();
            var expected = new int[] { 50, 66, 60 };
            var demand = new Demand { groupnum = "4", col = "Revenue" };
            //act

            var actual = target.AddRecord(demand, GetTestData());

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
    public class Record
    {
        public int ID { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }


    public interface ICalculator
    {
        List<int> AddRecord<T>(IDemand demand, List<T> records);
    }

    public class Calculator : ICalculator
    {
        public List<int> AddRecord<T>(IDemand demand, List<T> records)
        {
            throw new NotImplementedException();
        }
    }



    public interface IDemand
    {
        string groupnum { get; set; }
        string col { get; set; }
    }

    public class Demand : IDemand
    {
        public string col
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string groupnum
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
