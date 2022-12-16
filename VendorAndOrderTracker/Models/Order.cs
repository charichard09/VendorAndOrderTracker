using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Models;

public class Order
{
  public string Price { get; set; }
  public string Title { get; set; }
  public string Description { get; set; }
  public int Id { get; }
  private static List<Order> _instances = new List<Order> {};
  public DateTime TodaysDate { get; set; }

  public Order(string title, string description, string price)
  {
    Title = title;
    Description = description;
    _instances.Add(this);
    Id = _instances.Count;
    TodaysDate = DateTime.Today;
    Price = price;
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }

  public static List<Order> GetAll()
  {
    return _instances;
  }

  public static Order Find(int searchId)
  {
    return _instances[searchId-1];
  }
}
