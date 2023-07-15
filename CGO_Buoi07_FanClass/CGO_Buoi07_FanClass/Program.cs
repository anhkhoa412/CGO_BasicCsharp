using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi07_FanClass
{
    class Fan
    {
        private const int SLOW = 1;
        private const int MEDIUM = 2;
        private const int FAST = 3;

        private int speed;
        private bool on;
        private double radius;
        private string color;

        public Fan()
        {
            this.speed = SLOW;
            this.on = false;
            this.radius = 5;
            this.color = "blue";
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool On
        {
            get { return on; }
            set { on = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            if (on)
            {
                return $"Speed: {speed}, Color: {color}, Radius: {radius}, Fan is on";
            }
            else
            {
                return $"Color: {color}, Radius: {radius}, Fan is off";
            }
        }




        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            fan1.Speed = 3;
            fan1.Radius = 10;
            fan1.Color = "yellow";
            fan1.On = true;

            Fan fan2 = new Fan();
            fan2.Speed = 2;
            fan2.Radius = 5;
            fan2.Color = "blue";
            fan2.On = false;

            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());

        }
    }
}

