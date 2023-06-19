using AspNetCoreCourse.Models;
using AspNetCoreCourse.Models.ViewModels;
using AutoMapper;

namespace AspNetCoreCourse.AutoMapper
{
    public class PersonelProfil :Profile
    {

        public PersonelProfil()
        {
            CreateMap<PersonelCreateViewModel, Personel>();
            CreateMap<Personel,PersonelCreateViewModel>();
        }

    }
}
