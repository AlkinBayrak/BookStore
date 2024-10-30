using System.ComponentModel.DataAnnotations;

namespace BookStore.WebApp.Models
{
    public class CityViewModel : BaseViewModel
    {
        [Display(Name ="Şehir Adı")]
        [Required(ErrorMessage ="Bu alan zorunludur.")]
        public string Name { get; set; }

        [Display(Name = "Şehir Durumu")]
        public bool Status { get; set; }
    }
}
