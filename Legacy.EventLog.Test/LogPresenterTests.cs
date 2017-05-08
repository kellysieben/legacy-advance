﻿using Legacy.EventLog.Model;
using Legacy.EventLog.Presenter;
using Legacy.EventLog.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Legacy.EventLog.Test
{
    [TestClass]
    public class LogPresenterTests
    {
        private ILogService _service;
        private ILogView _view;
        private LogPresenter _sut;

        [TestInitialize]
        public void TestInitialize()
        {
            _service = Substitute.For<ILogService>();
            _view = Substitute.For<ILogView>();
            _sut = new LogPresenter(_view, _service);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _service = null;
            _view = null;
            _sut = null;
        }

        [TestMethod]
        public void WhenNewEntry_ShouldAddToLog()
        {
            // Arrange
            var entries = new string[] {"Hello from this side."};
            _view.NewEntry.Returns("Hello from this side.");
            _service.GetAllEntries().Returns(entries);

            // Act
            _sut.NewEntry();

            // Assert
            Assert.AreEqual("", _view.NewEntry);
            CollectionAssert.AreEqual(_view.Log, entries);
        }

        [TestMethod]
        public void WhenNewEntry_ShouldUpdateInfoStatus()
        {
            // Arrange
            var entries = new[] { "Hello from this side." };
            _service.EntryCounter.Returns(entries.Length);
            _view.NewEntry.Returns("Hello from this side.");

            // Act
            _sut.NewEntry();

            // Assert
            Assert.AreEqual("Number of Entries: 1", _view.InfoStatus);
        }
    }
}
