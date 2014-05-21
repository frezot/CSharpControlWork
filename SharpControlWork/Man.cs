using Seterlund.CodeGuard;

namespace SharpControlWork
{
    class Man
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                Guard.That(value).IsNotNullOrEmpty();
                _name = value;
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                Guard.That(value).IsPositive();
                _age = value;
            }
        }

    }
}
