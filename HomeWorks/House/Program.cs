using System;

namespace House
{
    class House
    {
        protected int area;
        protected Door door;
        public House(int area)
        {
            this.area = area;
            door = new Door();
        }
        public int Area
        {
            get { return area; }
            set { area = value; }
        }
        public Door Door
        {
            get { return door; }
            set { door = value; }
        }
        public virtual void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} m2.", area);
        }
    }
    class Door
    {
        protected string color;
        public Door()
        {
            color = "Brown";
        }
        public Door(string color)
        {
            this.color = color;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is {0}.", color);
        }
    }

    class SmallApartment : House
    {
        public SmallApartment() : base(50)
        {
        }
        public override void ShowData()
        {
            Console.WriteLine("I am an apartment, my area is " +
            area + " m2");
        }
    }

    class Habitant
    {
        protected string name;
        protected House house;
        public Habitant()
        {
            name = "Olga";
            house = new House(180);
        }
        public Habitant(string name, House house)
        {
            this.name = name;
            this.house = house;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public House House
        {
            get { return house; }
            set { house = value; }
        }
        public void ShowData()
        {
            Console.WriteLine("My name is {0}.", name);
            house.ShowData();
            house.Door.ShowData();
        }
    }

    class TestHouse
    {
        static void Main()
        {
            bool debug = true;
            SmallApartment mySmallApartament = new SmallApartment();
            Habitant myHabitant = new Habitant();
            myHabitant.House = mySmallApartament;
            myHabitant.ShowData();
            myHabitant.Name = "Olga";
            if (debug)
                Console.ReadLine();
        }
    }
}
