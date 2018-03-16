using System.Collections.Generic;

namespace TheDeptBook.Model
{
    class DeptModel
    {
        private List<Person> persons = new List<Person>();
        private List<Loan> loan1 = new List<Loan>();
        private List<Loan> loan2 = new List<Loan>();
        private List<Loan> loan3 = new List<Loan>();

        public DeptModel()
        {
            loan1.Add(new Loan("Kaffe", -9));
            persons.Add(new Person("Anders", loan1));
            loan1.Add(new Loan("Kage", -12));
            loan1.Add(new Loan("Pizza", +35));
            persons.Add(new Person("Morten", loan2));
            loan2.Add(new Loan("Flybillet til Maldiverne", -4979));
            loan2.Add(new Loan("Dykkertur", -1989));
            persons.Add(new Person("Udbetaling Danmark", loan3));
            loan3.Add(new Loan("Kontigent", -75));

        }
        public List<Person> GetPersons()
        {
            return persons;
        }
    }
}
