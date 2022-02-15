using System;
using System.Collections.Generic;
using KeyBoardChecker.BLL.Interfaces;
using KeyBoardChecker.BLL.Services;
using KeyBoardChecker.DAL.Interfaces.Repositories;
using KeyBoardChecker.DAL.Models;
using Moq;
using NUnit.Framework;

namespace KeyBoardChecker.UnitTests
{   
    [TestFixture]
    public class HistoryLogServiceTests
    {
        private readonly Mock<IHistoryRepository> mockHistoryRepository;
        private readonly IHistoryLogService historyLogService;

        public HistoryLogServiceTests()
        {
            this.mockHistoryRepository = new Mock<IHistoryRepository>();
            this.historyLogService = new HistoryLogService(mockHistoryRepository.Object);
        }

        [Test]
        public void AddHistoryLog_WhenCalled_CallRepositoryMethod()
        {
            historyLogService.AddHistoryLog("test");
            mockHistoryRepository.Verify(x => x.Add(It.IsAny<DateTime>(), "Was pressed Key test"), Times.Once);
        }

        [Test]
        public void ClearHistoryLog_WhenCalled_CallRepositoryMethod()
        {   
            historyLogService.ClearAllHistoryLog();
            mockHistoryRepository.Verify(x => x.Clear(), Times.Once);
        }

        [Test]
        public void DeleteElement_WhenCalled_CallRepositoryMethod()
        {   
            historyLogService.DeleteElement(123);
            mockHistoryRepository.Verify(x=>x.DeleteElement(123), Times.Once);
        }

        [Test]
        public void GetAllHistoryLog_WhenCalled_ReturnAllHistoryLogs()
        {
            var list = new List<HistoryLog>()
            {
                new HistoryLog()
                {
                    DateTime = DateTime.Now,
                    Id = 56783,
                    Value = "testik"
                }
            };
            mockHistoryRepository.Setup(x=>x.GetAllHistoryLog()).Returns(list);
            var actual = historyLogService.GetAllHistoryLog();
            Assert.AreEqual(actual, list);

        }
    }
}
