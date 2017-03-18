using System;

namespace Domain
{
    public class Cat
    {
        public Cat(CatColor c, string a)
        {
            Color = c;
            Age = a;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name)) _name = value; 
            }
        }
        public string Age { get; }
        public CatColor Color { get; set; }
        private int _health = 5; 
        public void Feed()
        {
            ++_health;
        } 

        public void Punish()
        {
            --_health;
        } 
        public string CurrentColor {
            get { return _health<5 ? Color.SickColor : Color.HealthyColor; }
        }
    }
}