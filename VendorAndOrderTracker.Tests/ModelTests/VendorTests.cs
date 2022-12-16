using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests;

[TestClass]
public class VendorTests : IDisposable
{
  public void Dispose()
  {
    Vendor.ClearAll();
  }

  [TestMethod]
  public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
  {
    Vendor newVendor = new Vendor("testName", "testDescription");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
  }

  [TestMethod]
  public void GetNameAndDescription_ReturnsNameAndDescription_String()
  {
    string name = "TestVendor";
    string description = "TestDescription";
    Vendor newVendor = new Vendor(name, description);

    Assert.AreEqual(name, newVendor.Name);
    Assert.AreEqual(description, newVendor.Description);
  }

  [TestMethod]
  public void GetId_ReturnsVendorId_Int()
  {
    string name = "TestVendor";
    string description = "TestDescription";
    Vendor newVendor = new Vendor(name, description);

    int result = newVendor.Id;

    Assert.AreEqual(1, result);
  }

  [TestMethod]
  public void GetAll_ReturnsAllVendorObjects_VendorList()
  {
    string name1 = "TestVendor1";
    string description1 = "TestDescription1";
    Vendor newVendor1 = new Vendor(name1, description1);
    string name2 = "TestVendor2";
    string description2 = "TestDescription2";
    Vendor newVendor2 = new Vendor(name2, description2);
    List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

    List<Vendor> result = Vendor.GetAll();

    CollectionAssert.AreEqual(newList, result);
  }

  [TestMethod]
  public void Find_ReturnsCorrectVendor_Vendor()
  {
    string name1 = "TestVendor1";
    string description1 = "TestDescription1";
    Vendor newVendor1 = new Vendor(name1, description1);
    string name2 = "TestVendor2";
    string description2 = "TestDescription2";
    Vendor newVendor2 = new Vendor(name2, description2);

    Vendor result = Vendor.Find(2);

    Assert.AreEqual(newVendor2, result);
  }

  [TestMethod]
  public void AddOrder_AssociatesOrderWithVendor_OrderList()
  {
    string title = "Bread";
    string description1 = "food made of flour, water, and yeast or another leavening agent, mixed together and baked.";
    string price1 = "5";
    Order newOrder = new Order(title, description1, price1);
    List<Order> newList = new List<Order> { newOrder };
    string name = "TestVendor";
    string description2 = "TestDescription";
    Vendor newVendor = new Vendor(name, description2);
    newVendor.AddOrder(newOrder);

    List<Order> result = newVendor.Orders;

    CollectionAssert.AreEqual(newList, result);
  }
}
