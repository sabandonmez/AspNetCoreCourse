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
    }
}
