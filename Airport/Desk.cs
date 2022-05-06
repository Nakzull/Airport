using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Desk
    {       
        Queue<Luggage> luggage;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Desk (string name)
        {
            Name = name;
        }

        public Desk(Queue<Luggage> luggageGet)
        {
            luggage = luggageGet;
        }

        public Desk()
        {

        }

        public void TakeLuggage()
        {

        }
        public void SendLuggage(Queue<Luggage> luggageSend)
        {

        }
    }
}
