using System;

namespace Template.Models.ViewModels
{
    public class PeopleViewModel
    {
        public Guid Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public int Age { get => CalculateAge(); }

        private int CalculateAge()
        {
            DateTime dateNow = DateTime.Now;

            int age = dateNow.Year - BirthDate.Year;

            if (dateNow.Month < BirthDate.Month || (dateNow.Month == BirthDate.Month && BirthDate.Day < dateNow.Day))
                age -= 1;

            return age;
        }
    }
}
