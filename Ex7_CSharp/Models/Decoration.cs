using System;

namespace Ex7_CSharp
{
    public class Decoration
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public double Price { get; set; }

        public Decoration (string Name, string Material, double Price)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
        }
        
        public string getDecorationInfo()
        {
            return $"- Id: {Id}\n- Tipus: {Name}\n- Material: {Material}\n- Preu: {Price} euros\n";
        }
    }
}