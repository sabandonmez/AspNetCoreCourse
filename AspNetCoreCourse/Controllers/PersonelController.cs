using AspNetCoreCourse.Business;
using AspNetCoreCourse.Models;
using AspNetCoreCourse.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCourse.Controllers
{
    public class PersonelController : Controller
    {
        public IMapper Mapper { get; }

        public PersonelController(IMapper mapper)
        {
            Mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonelCreateViewModel viewModeldenGelecekVeriler)
        {
            Personel p = Mapper.Map<Personel>(viewModeldenGelecekVeriler);
            PersonelCreateViewModel vm = Mapper.Map<PersonelCreateViewModel>(p);
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

