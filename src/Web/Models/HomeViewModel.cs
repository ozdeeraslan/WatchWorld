using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Models
{
    public class HomeViewModel
    {
        public List<CatalogItemViewModel> CatalogItems { get; set; } = new List<CatalogItemViewModel>();

        public List<SelectListItem>? Brands { get; set; } = new List<SelectListItem>();

        public List<SelectListItem>? Categories { get; set; } = new List<SelectListItem>();

        public int? CategoryId { get; set; }

        public int? BrandId { get; set; }

        public PaginationInfoViewModel PaginationInfo { get; set; } = null!;
    }
}
