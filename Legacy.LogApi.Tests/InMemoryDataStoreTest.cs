using Legacy.LogApi.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Legacy.LogApi.Tests
{
    [TestClass]
    public class InMemoryDataStoreTest
    {
        [TestMethod]
        public void AfterAddingItemsAndClearingInMemoryDataStoreShouldResetToEmpty()
        {
            InMemoryDataStore.Add("item1");
            InMemoryDataStore.Add("item2");
            InMemoryDataStore.Add("item3");
            InMemoryDataStore.Add("item4");
            InMemoryDataStore.Add("item5");

            Assert.IsTrue(InMemoryDataStore.Get().Count > 0);

            InMemoryDataStore.Clear();

            Assert.AreEqual(0, InMemoryDataStore.Get().Count);
        }

        [TestMethod]
        public void InMemoryDataStoreShouldAddOneItem()
        {
            InMemoryDataStore.Clear();
            InMemoryDataStore.Add("item1");

            Assert.AreEqual(1, InMemoryDataStore.Get().Count);
        }

        [TestMethod]
        public void InMemoryDataStoreShouldAddMultipleItems()
        {
            InMemoryDataStore.Clear();
            InMemoryDataStore.Add("item1");
            InMemoryDataStore.Add("item2");
            InMemoryDataStore.Add("item3");
            InMemoryDataStore.Add("item4");
            InMemoryDataStore.Add("item5");

            Assert.AreEqual(5, InMemoryDataStore.Get().Count);
        }
    }
}
