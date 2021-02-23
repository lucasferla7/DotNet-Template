using System;
using Template.Models.ViewModels;

namespace Template.Services.People
{
    public interface IPeopleService
    {
        PeopleViewModel GetPeople(Guid id);
        void AddPeople(PeopleViewModel people);
    }
}
