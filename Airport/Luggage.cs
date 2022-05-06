using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Luggage
    {
        static int count = 1;
        Queue<Luggage> luggageQueue;
        Random rng = new Random();
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string destination;

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }


        public Luggage(Queue<Luggage> luggage)
        {
            luggageQueue = luggage;
        }
        public Luggage()
        {

        }
        public Luggage(string company)
        {
            Id = count;
            count++;
            Company = company;
        }

        public void CreateLuggage()
        {           
            string randomCompany;
            while (true)
            {
                if (rng.Next(1, 4) == 1)
                    randomCompany = "SAS";
                else if (rng.Next(1, 4) == 2)
                    randomCompany = "Noric Air";
                else
                    randomCompany = "Lufthansa";
                Luggage luggage = new Luggage(randomCompany);
                lock (luggageQueue)
                {
                    luggageQueue.Enqueue(luggage);
                    CompanySorter companySorter = new CompanySorter(luggageQueue);
                }
            }
        }
    }
}
