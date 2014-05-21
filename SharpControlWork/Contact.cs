using Seterlund.CodeGuard;

namespace SharpControlWork
{
    class Contact
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

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                Guard.That(value).Contains("@");
                _email = value;
            }
        }
    }
}
