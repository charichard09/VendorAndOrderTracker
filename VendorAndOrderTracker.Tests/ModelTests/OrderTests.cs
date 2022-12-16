using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Tests;

[TestClass]
public class OrderTests : IDisposable
{
  public void Dispose()
  {
    Order.ClearAll();
  }

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

    [TestMethod]
    public void SetDescriptionAndTitle_SetDescriptionAndTitle_String()
    {
      string title = "Bread";
      string description = "food made of flour, water, and yeast or another leavening agent, mixed together and baked.";
      Order newOrder = new Order(title, description);
      string updatedTitle = "Croissant";
      string updatedDescription = "a flaky rich crescent-shaped roll";
      newOrder.Title = updatedTitle;
      newOrder.Description = updatedDescription;

    Assert.AreEqual(updatedTitle, newOrder.Title);
    Assert.AreEqual(updatedDescription, newOrder.Description);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title1 = "Bread";
      string description1 = "food made of flour, water, and yeast or another leavening agent, mixed together and baked.";
      Order newOrder1 = new Order(title1, description1);
      string title2 = "Croissant";
      string description2 = "a flaky rich crescent-shaped roll";
      Order newOrder2 = new Order(title2, description2)
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "Bread";
      string description = "food made of flour, water, and yeast or another leavening agent, mixed together and baked.";
      Order newOrder = new Order(title, description);

      // Act 
      int result = newOrder.Id;

      // Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title1 = "Bread";
      string description1 = "food made of flour, water, and yeast or another leavening agent, mixed together and baked.";
      Order newOrder1 = new Order(title1, description1);
      string title2 = "Croissant";
      string description2 = "a flaky rich crescent-shaped roll";
      Order newOrder2 = new Order(title2, description2)

      // Act
      Order result = Order.Find(2);

      // Assert
      Assert.AreEqual(newOrder2, result);
    }
}
