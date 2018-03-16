namespace TheDeptBook.Model
{
    class Loan
    {
        public string Description; //{ get; set; }
        public double Value; // { get; set; }

        public Loan(string d, double v)
        {
            Description = d;
            Value = v;
        }
    }
}
