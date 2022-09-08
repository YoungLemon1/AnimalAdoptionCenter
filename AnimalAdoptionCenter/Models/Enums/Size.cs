using System.ComponentModel.DataAnnotations;

namespace AnimalAdoptionCenter.Models.Enums
{
    public enum eSize
    {
        [Display(Name = "Tiny")]
        Tiny,
        [Display(Name = "Small")]
        Small,
        [Display(Name = "Medium")]
        Medium,
        [Display(Name = "Large")]
        Large
    }
}