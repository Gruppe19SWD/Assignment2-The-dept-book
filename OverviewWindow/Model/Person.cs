using System.Collections.Generic;

namespace OverviewWindow.Model
{
    class Person
    {
        private string _name;
        private List<Loan> _loans;
        private double _total;

        public Person(string n, List<Loan> l)
        {
            _name = n;
            _loans = l;
            _total = CalculateTotal();
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var dept in _loans)
            {
                total += dept.Value;
            }

            return total;
        }
    }
}
