using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests;

[TestClass]
public class OrderTests
{
  [TestMethod]
  public void OrderConstructor_CreatesInstanceOfOrder_Order()
  {
    Order newOrder = new Order("testName", "testDescription");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
  }
}
