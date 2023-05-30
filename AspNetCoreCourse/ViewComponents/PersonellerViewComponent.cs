using AspNetCoreCourse.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCourse.ViewComponents
{
    public class PersonellerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Personel> personels = new List<Personel>
            {
                new Personel { Adi="Mehmet" ,Soyadi="Muş"},
                new Personel { Adi="Ali",Soyadi="Sayan"},
                new Personel{ Adi="Şaban",Soyadi="Dönmez"},
                new Personel{Adi="Meryem",Soyadi="Gümüş"}
            };

            return View(personels);
        }
    }
}