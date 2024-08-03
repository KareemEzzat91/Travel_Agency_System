namespace Travel_Agency_System
{
    class TravelEntity
    {
        private string name;
        private string description;

        public TravelEntity()
        {
            this.name = "";
            this.description = "";
        }
        public TravelEntity(string name,string description)
        {
            this.name = name;
            this.description = description;
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public string Description
        {
            set { this.description = value; }
            get { return this.description; }
        }
        
    }
}
