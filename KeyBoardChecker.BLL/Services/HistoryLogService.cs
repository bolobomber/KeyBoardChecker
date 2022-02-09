﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyBoardChecker.BLL.Interfaces;
using KeyBoardChecker.DAL.Interfaces.Repositories;

namespace KeyBoardChecker.BLL.Services
{
    public class HistoryLogService : IHistoryLogService
    {
        private readonly IHistoryRepository historyRepository;
        public HistoryLogService(IHistoryRepository historyRepository)
        {
            this.historyRepository = historyRepository;
        }

        

        public void AddHistoryLog(string key)
        {
            key = "Was pressed Key " + key;
            historyRepository.Add(DateTime.Now, key);
        }
    }
}