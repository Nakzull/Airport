using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Airport
{
    class CompanySorter
    {
        Queue<Luggage> luggage = new Queue<Luggage>();
        Queue<Luggage> luggageSas = new Queue<Luggage>();
        Queue<Luggage> luggageNordicAir = new Queue<Luggage>();
        Queue<Luggage> luggageLufthansa = new Queue<Luggage>();

        public CompanySorter()
        {

        }
        public CompanySorter (Queue<Luggage> luggageQueue)
        {
            luggage = luggageQueue;           
        }

        public void splitCompany()
        {
            while (true)
            {
                lock (luggage)
                {
                    if (luggage.Count > 0)
                    {
                        Luggage temp = luggage.Dequeue();
                        if (temp.Company == "SAS")
                        {
                            lock (luggageSas)
                            {
                                luggageSas.Enqueue(temp);
                                
                            }
                        }
                        else if (temp.Company == "Nordic Air")
                        {
                            lock (luggageNordicAir)
                            {
                                luggageNordicAir.Enqueue(temp);
                            }
                        }
                        else
                        {
                            lock (luggageLufthansa)
                            {
                                luggageLufthansa.Enqueue(temp);
                            }
                        }
                    }
                    else
                    {
                        Monitor.PulseAll(luggage);
                        Monitor.Wait(luggage);
                    }
                }
            }
        }
    }
}
