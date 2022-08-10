using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise;

[TestClass]
public class CalculatorTests
{
    private ListCalculator _sut; //subject under test

    public CalculatorTests() //set up done in contructor 
    {
        var calculator = new Calculator();
        _sut = new ListCalculator(calculator);
        //var listCalculator = new ListCalculator(); cannot pass in in interface;initialisation of the implementation of the interface is required.
    }
    
    [TestMethod]
    public void return_empty_list()
    {
        //arrange
        var emptyList = new List<int>();
        //act
        var result = _sut.MultiplyList(emptyList, 5);
        //assert
        CollectionAssert.AreEquivalent(emptyList.ToList(),result.ToList());
        //Assert.AreEqual(1,1);
        //Assert.AreEqual(true,false);
    }

    [TestMethod]
    public void int_is_multiplied()
    {
        //arrange
        var list = new[] {1, 2, 3};
        //act
        var result = _sut.MultiplyList(list, 5);
        //assert
        CollectionAssert.AreEquivalent(list,result.ToList());
    }
}