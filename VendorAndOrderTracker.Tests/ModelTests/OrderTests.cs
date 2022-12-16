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

  [TestMethod]
  public void GetDescriptionAndTitle_ReturnsDescriptionAndTitle_String()
  {
    string title = "Bread";
    string description = "food made of flour, water, and yeast or another leavening agent, mixed together and baked.";
    Order newOrder = new Order(title, description);
    Assert.AreEqual(title, newOrder.Title);
    Assert.AreEqual(description, newOrder.Description);
  }
}
