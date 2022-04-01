using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace Szakdoga.Models
{
    public class OrderCreateVM
    {
        public IEnumerable<SelectListItem> FoodItems;
        public IEnumerable<SelectListItem> TableItems;
    }
}
