using System.ComponentModel.DataAnnotations;

namespace AnimalAdoptionCenter.Models.Enums
{
    public enum eStatus
    {
        [Display(Name = "In rehab")]
        In_Rehab,
        [Display(Name = "Ready for adoption")]
        Ready_For_Adoption,
        [Display(Name = "Adopted")]
        Adopted,
        [Display(Name = "Missing")]
        Missing,
        [Display(Name = "Injured")]
        Injured,
        [Display(Name = "Gravely Injured")]
        Gravely_Injured,
        [Display(Name = "Deceased")]
        Deceased
    }


}