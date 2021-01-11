using System;

namespace Ex7_CSharp
{
    public class Tree
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Price { get; set; }

        public Tree (string Name, double Height, double Price)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Height = Height;
            this.Price = Price;
        }

        public string getTreeInfo()
        {
            return $"- Id: {Id}\n- Nom: {Name}\n- Alçada: {Height} centímetres\n- Preu: {Price} euros\n";
        }
    }
}