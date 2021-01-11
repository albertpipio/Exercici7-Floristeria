using System;

namespace Ex7_CSharp
{
    public class Flower
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Price { get; set; }

        public Flower (string Name, string Colour, double Price)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Colour = Colour;
            this.Price = Price;
        }

        public string getFlowerInfo()
        {
            return $"- Id: {Id}\n- Nom: {Name}\n- Color: {Colour}\n- Preu: {Price} euros\n";
        }
    }
}