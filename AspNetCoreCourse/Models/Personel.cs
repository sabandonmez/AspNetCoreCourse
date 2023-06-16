using AspNetCoreCourse.Models.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreCourse.Models
{
    public class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Pozisyon { get; set; }
        public int Maas { get; set; }
        public bool MedeniHal { get; set; }
    
    
       public static explicit operator PersonelCreateViewModel(Personel model)
        {
            return new PersonelCreateViewModel
            {
                Adi = model.Adi,
                Soyadi = model.Soyadi
            };
        }

        public static explicit operator Personel(PersonelCreateViewModel model)
        {
            return new Personel
            {
                Adi = model.Adi,
                Soyadi = model.Soyadi
            };
        }


    }




}
