using System.Collections.Generic;

namespace TheDeptBook.Model
{
    class DeptModel
    {
        private List<Person> persons = new List<Person>();
        private List<Loan> loan1 = new List<Loan>();

        public DeptModel()
        {
            loan1.Add(new Loan("Købte kaffe", -9));
            persons.Add(new Person("Anders",loan1));
            
        }

        public List<Person> GetPersons()
        {
            return persons;
        }

    }
}
