using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GoFish.Models;
using System;

namespace GoFish.Tests
{
  [TestClass]
  public class PlayerTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }

    // [TestMethod]
    // public void ItemConstructor_CreatesInstanceOfItem_Item()
    // {
    //   Item newItem = new Item("test");
    //   Assert.AreEqual(typeof(Item), newItem.GetType());
    // }
  }
}