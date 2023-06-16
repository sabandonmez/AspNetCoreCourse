using System.ComponentModel.DataAnnotations;

namespace AspNetCoreCourse.Models.ViewModels
{
    public class PersonelCreateViewModel
    {

        [Required]
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
