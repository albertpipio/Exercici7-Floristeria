namespace Ex7_CSharp
{
    public class FlowerShop
    {
        public string Name { get; set; }
        public int YearOfCreation { get; set; }
        
        public FlowerShop (string Name, int YearOfCreation)
        {
            this.Name = Name;
            this.YearOfCreation = YearOfCreation;
        }
    }
}