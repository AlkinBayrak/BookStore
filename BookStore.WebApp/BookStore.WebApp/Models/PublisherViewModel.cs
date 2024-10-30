using System.ComponentModel.DataAnnotations;

namespace BookStore.WebApp.Models
{
    public class PublisherViewModel : BaseViewModel
    {
        [Display(Name="Yayınevi Adı")]
        [Required(ErrorMessage ="Bu alan zorunludur")]
        public string Name { get; set; }

        [Display(Name = "Yayınevi Adresi")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Address { get; set; }

        public string? CityName { get; set; }

        [Display(Name = "Yayınevinin Bulunduğu Şehir ")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public int CityId { get; set; }

        public bool Status { get; set; }


    }
}
