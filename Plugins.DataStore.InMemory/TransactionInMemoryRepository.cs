using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class TransactionInMemoryRepository : ITransactionRepository
    {
        private List<Transaction> transactions;

        public TransactionInMemoryRepository()
        {
            transactions = new List<Transaction>();
        }
        public IEnumerable<Transaction> GetByDay(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void Save(string cashierName, int productId, double price, int qty)
        {
            int transactionId = 0;
            if (transactionId != null && transactions.Count > 0)
            {
                int maxId = transactions.Max(x => x.TransactionId);
                transactionsId = maxId + 1;
            }
            else
            {
                transactionId = 1;
            }
            transactions.Add(new Transaction
            {
                ProductId = productId,
                TimeStamp = DateTime.Now,
                Price = price,
                Qty = qty,
            });
        }
    }
}
