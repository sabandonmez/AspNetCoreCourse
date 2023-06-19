using AspNetCoreCourse.Business;
using AspNetCoreCourse.Models;
using AspNetCoreCourse.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCourse.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonelCreateViewModel viewModeldenGelecekVeriler)
        {
       
            PersonelCreateViewModel vm = TypeConversion.Conversion<Personel, PersonelCreateViewModel>(new Personel{ Adi = "dasda", Soyadi = "adsdads" });

            return View();
        }
        public IActionResult Listele()
        {

            List<PersonelListViewModel> personels = new List<Personel>
            {
                new Personel { Adi="A1" ,Soyadi="B1" ,Pozisyon="C1" },
                new Personel { Adi="A2" ,Soyadi="B2" ,Pozisyon="C2" },
                new Personel { Adi="A3" ,Soyadi="B3" ,Pozisyon="C3" },
                new Personel { Adi="A4" ,Soyadi="B4" ,Pozisyon="C4" },
                new Personel { Adi="A5" ,Soyadi="B5" ,Pozisyon="C5" },
            }.Select(p => new PersonelListViewModel
            {
                Adi = p.Adi,
                Soyadi = p.Soyadi,
                Pozisyon = p.Pozisyon
            }).ToList();

            return View(personels);
        }

        public IActionResult Get()
        {
            var nesne = (new Personel(), new Urun(), new Musteri());
            return View(nesne);
        }

    }
}

