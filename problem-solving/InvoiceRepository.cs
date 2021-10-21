using System;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceRepository.Tests
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private IQueryable<Invoice> _invoices {get; set;}
        
        public InvoiceRepository(IQueryable<Invoice> invoices)
        {
            // Console.WriteLine("Sample debug output");
            _invoices = invoices;
        }

        /// <summary>
        /// Should return a total value of an invoice with a given id. If an invoice does not exist null should be returned.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        public decimal? GetTotal(int invoiceId)
        {
            // If an invoice does not exist null should be returned.
            var invoice = _invoices.Where(x => x.Id == invoiceId).FirstOrDefault();
            if (invoice == null) return null;

            // Calculate total
            return invoice.InvoiceItems.Sum(x => x.Price * x.Count);
        }

        /// <summary>
        /// Should return a total value of all unpaid invoices.
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalOfUnpaid()
        {
            var allUnpaidInvoicesItems = _invoices
              .Where(x => x.AcceptanceDate == null)
              .Select(p => p.InvoiceItems.Sum(x => x.Price * x.Count));
            
            return allUnpaidInvoicesItems.FirstOrDefault();
        }

        /// <summary>
        /// Should return a dictionary where the name of an invoice item is a key and the number of bought items is a value.
        /// The number of bought items should be summed within a given period of time (from, to). Both the from date and the end date can be null.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public IReadOnlyDictionary<string, long> GetItemsReport(DateTime? from, DateTime? to)
        {
            throw new NotImplementedException();
            // IQueryable<Invoice> result = _invoices.AsQueryable();
            // if (from.HasValue && to.HasValue)
            //   result = _invoices.Where(x => x.CreationDate > from.Value && x.CreationDate < to.Value);
            // else if (from.HasValue) 
            //   result = _invoices.Where(x => x.CreationDate > from.Value);
            // else if (to.HasValue)
            //   result = _invoices.Where(x => x.CreationDate < to.Value);

            // var items = result.Select(x => x.InvoiceItems);

            // return items.ToDictionary(x => x.Name, x => (long)x.Count);
        }
    }
}

public class Invoice
{
    // A unique numerical identifier of an invoice (mandatory)
    public int Id { get; set; }
    // A short description of an invoice (optional).
    public string Description { get; set; }
    // A number of an invoice e.g. 134/10/2018 (mandatory).
    public string Number { get; set; }
    // An issuer of an invoice e.g. Metz-Anderson, 600  Hickman Street,Illinois (mandatory).
    public string Seller { get; set; }
    // A buyer of a service or a product e.g. John Smith, 4285  Deercove Drive, Dallas (mandatory).
    public string Buyer { get; set; }
    // A date when an invoice was issued (mandatory).
    public DateTime CreationDate { get; set; }
    // A date when an invoice was paid (optional).
    public DateTime? AcceptanceDate { get; set; }
    // A collection of invoice items for a given invoice (can be empty but is never null).
    public IList<InvoiceItem> InvoiceItems { get; }

    public Invoice()
    {
        InvoiceItems = new List<InvoiceItem>();
    }
}



public class InvoiceItem
{
    // A name of an item e.g. eggs.
    public string Name { get; set; }
    // A number of bought items e.g. 10.
    public unit Count { get; set; }
    // A price of an item e.g. 20.5.
    public decimal Price { get; set; }
}
