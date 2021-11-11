using AcompanhamentoPlanoCarreira.Models.Enums;

namespace AcompanhamentoPlanoCarreira.Models
{
    public class SallesRecord
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public Double Amount { get; set; }

        public SaleStatus Status { get; set; }

        public Seller Seller { get; set; }

        public SallesRecord()
        {

        }

        public SallesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
