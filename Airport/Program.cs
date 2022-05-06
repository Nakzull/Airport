using System;
using System.Collections.Generic;
using System.Threading;

namespace Airport
{
    class Program
    {
        static Queue<Luggage> luggageQueue = new Queue<Luggage>();
        static Queue<Luggage> luggageSas = new Queue<Luggage>();
        static Queue<Luggage> luggageNordicAir = new Queue<Luggage>();
        static Queue<Luggage> luggageLuftHansa = new Queue<Luggage>();
        static Queue<Luggage> luggageCopenhagen = new Queue<Luggage>();
        static Queue<Luggage> luggageParis = new Queue<Luggage>();
        static Queue<Luggage> luggageLondon = new Queue<Luggage>();
        static void Main(string[] args)
        {
            Luggage luggage = new Luggage(luggageQueue);
            CompanySorter companySorter = new CompanySorter();
            Desk deskSas = new Desk("SAS");
            Desk deskNordicAir = new Desk("Nordic Air");
            Desk deskLufthansa = new Desk("Lufthansa");
            Thread t1 = new Thread(luggage.CreateLuggage);
            Thread t2 = new Thread(companySorter.splitCompany);

        }
    }
}
