namespace Travel_Agency_System
{
    class Customer
    {
        private string name;
        private string email;

        public Customer() 
        {
            this.name = "";
            this.email = "";
        }
        public Customer(string name,string email) 
        {
            this.name = name;
            this.email = email;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }

    }
}
