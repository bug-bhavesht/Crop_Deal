using Crop_Deal.Models;

namespace Crop_Deal.Infrastructure
{
    public interface IInvoice
    {
        Task<Invoice> CreateInvoice(Invoice invoice);
        Task<IEnumerable<Invoice>> GetInvoices();
        Task<Invoice> GetInvoice(int id);
        Task<Invoice> DeleteInvoice(int id);
    }
}
