namespace SharpControlWork
{
    class Apple: Fruit
    {
        public Apple():base("apple")
        {
            //nothing
        }

        public string ShowName()
        {
            return Name;
        }
    }
}
