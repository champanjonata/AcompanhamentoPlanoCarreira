namespace AcompanhamentoPlanoCarreira.Models.ViewModels
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set;} = new List<Seller>();

         public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSalles(DateTime inicial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSalles(inicial, final));
        }
    }
}
