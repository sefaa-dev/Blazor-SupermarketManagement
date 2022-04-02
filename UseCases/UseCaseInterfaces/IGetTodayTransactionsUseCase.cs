﻿using System.Collections.Generic;
using System.Transactions;

namespace UseCases
{
    public interface IGetTodayTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
    }
}