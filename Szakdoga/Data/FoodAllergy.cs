using System.ComponentModel.DataAnnotations.Schema;

namespace Szakdoga.Data
{
    public class FoodAllergy : BaseEntity
    {
        [ForeignKey("FoodAllergyTypeId")]
        public int FoodAllergyTypeId { get; set; }
        public FoodAllergyType FoodAllergyType { get; set; }
        [ForeignKey("FoodId")]
        public int FoodId { get; set; }
        public Food Food { get; set; }
    }
}
