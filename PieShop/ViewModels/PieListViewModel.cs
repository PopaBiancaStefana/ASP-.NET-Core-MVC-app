using PieShop.Models;

namespace PieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string? CurrentCategory { get; }

        public PieListViewModel(IEnumerable<Pie> pies, string? currentCatgory)
        {
            Pies = pies;
            CurrentCategory = currentCatgory;
        }
    }
}
