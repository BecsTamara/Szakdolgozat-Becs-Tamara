using Microsoft.AspNetCore.Mvc.Rendering;
using Szakdoga.Data;

namespace Szakdoga.Configurations
{
    public static class Extensions
    {
        public static IEnumerable<SelectListItem> ToSelectList(this IEnumerable<int> data, int dataType)
        {
            List<SelectListItem> ToSelectList = new List<SelectListItem>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                

                foreach (var item in data)
                {
                    if (dataType == 0)
                    {
                        FoodAllergyType allergy = db.FoodAllergyTypes.Single(i => i.Id == item);
                        ToSelectList.Add(new SelectListItem()
                        {
                            Text = allergy.Name,
                            Value = allergy.Id.ToString()
                        });
                    }
                    else if (dataType == 1)
                    {
                        FoodType valami = db.FoodTypes.Single(i => i.Id == item);
                        ToSelectList.Add(new SelectListItem()
                        {
                            Text = valami.Name,
                            Value = valami.Id.ToString()
                        });
                    }

                }
            }
            return ToSelectList;
        }

    }
}
