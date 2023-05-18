using Crop_Deal.Context;
using Crop_Deal.Infrastructure;
using Crop_Deal.Models;
using Microsoft.EntityFrameworkCore;

namespace Crop_Deal.Service
{
    public class InvoiceRepository : IInvoice
    {
        private readonly CD_DbContext context;

        public InvoiceRepository(CD_DbContext context)
        {
            this.context = context;
        }
        public async Task<Invoice> CreateInvoice(Invoice invoice)
        {
            await context.Invoices.AddAsync(invoice);
            await context.SaveChangesAsync();
            return invoice;
        }

        public async Task<Invoice> DeleteInvoice(int id)
        {
            var invoice = await context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                return null;
            }
            context.Invoices.Remove(invoice);
            return invoice;
        }

        public async Task<Invoice> GetInvoice(int id)
        {
            var invoice = await context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                return null;
            }
            return invoice;
        }

        public async Task<IEnumerable<Invoice>> GetInvoices()
        {
            return await context.Invoices.ToListAsync();
        }

    }
}
