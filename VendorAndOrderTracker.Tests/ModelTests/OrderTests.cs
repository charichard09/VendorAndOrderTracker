using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

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
    Order newOrder = new Order("testName", "testDescription", "testPrice");

    Assert.AreEqual(typeof(Order), newOrder.GetType());
  }

  [TestMethod]
  public void GetDescriptionPriceAndTitle_ReturnsDescriptionPriceAndTitle_String()
  {
    string title = "Bread";
    string description = "food made of flour, water, and yeast or another leavening agent, mixed together and baked.";
    string price = "5";
    Order newOrder = new Order(title, description, price);

    Assert.AreEqual(title, newOrder.Title);
    Assert.AreEqual(description, newOrder.Description);
    Assert.AreEqual(price, newOrder.Price);
  }

    [TestMethod]
    public void SetDescriptionPriceAndTitle_SetDescriptionPriceAndTitle_String()
    {
      string title = "Bread";
      string description = "food made of flour, water, and yeast or another leavening agent, mixed together and baked.";
      string price = "5";
      Order newOrder = new Order(title, description);
      string updatedTitle = "Croissant";
      string updatedDescription = "a flaky rich crescent-shaped roll";
      string updatePrice = "10";
      newOrder.Title = updatedTitle;
      newOrder.Description = updatedDescription;
      newOrder.Price = updatePrice;

    Assert.AreEqual(updatedTitle, newOrder.Title);
    Assert.AreEqual(updatedDescription, newOrder.Description);
    Assert.AreEqual(updatedPrice, newOrder.Price);
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
      string price1 = "5";
      Order newOrder1 = new Order(title1, description1, price1);
      string title2 = "Croissant";
      string description2 = "a flaky rich crescent-shaped roll";
      string price2 = "5";
      Order newOrder2 = new Order(title2, description2, price2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "Bread";
      string description = "food made of flour, water, and yeast or another leavening agent, mixed together and baked.";
      string price = "5";
      Order newOrder = new Order(title, description, price);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title1 = "Bread";
      string description1 = "food made of flour, water, and yeast or another leavening agent, mixed together and baked.";
      string price1 = "5";
      Order newOrder1 = new Order(title1, description1, price1);
      string title2 = "Croissant";
      string description2 = "a flaky rich crescent-shaped roll";
      string price2 = "5";
      Order newOrder2 = new Order(title2, description2, price2);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void SetDate_SetsDateOnInstanceOfOrder_String()
    {
      string title = "Bread";
      string description = "food made of flour, water, and yeast or another leavening agent, mixed together and baked.";
      string price = "5";
      Order newOrder = new Order(title, description, price);

      DateTime currentDate = DateTime.Today;

      Assert.AreEqual(currentDate, newOrder.TodaysDate);
    }
}
