using System;
using Template.Context.Context;
using Template.Context.Entities;
using Template.Models.ViewModels;

namespace Template.Services.People
{
    public class PeopleService : IPeopleService
    {
        private readonly TemplateContext _dataBase;

        public PeopleService(TemplateContext dataBase)
        {
            _dataBase = dataBase;
        }

        public void AddPeople(PeopleViewModel people)
        {
            PeopleEntity newPeople = new PeopleEntity
            {
                Id = people.Id,
                BirthDate = new DateTime(1992, 03, 26),
                Name = "Lucas Ferla Gomes"
            };
            _dataBase.Add(newPeople);
            _dataBase.SaveChanges();
        }

        public PeopleViewModel GetPeople(Guid id)
        {
            PeopleEntity people = _dataBase.People.Find(id);
            return new PeopleViewModel
            {
                Id = people.Id,
                BirthDate = people.BirthDate,
                Name = people.Name
            };
        }
    }
}
