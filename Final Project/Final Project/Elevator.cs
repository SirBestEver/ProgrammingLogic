using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Elevator
    {
        private double MaxWeight;
        private Passeger[] Occupants;
        

        public Elevator(int maxOccupants, double maxWeight)
        {
            MaxWeight = maxWeight;
            Occupants = new Passeger[maxOccupants]; 
        }

        public void AddOccupant(Passeger passenger,int index)
        {

            if (index < Occupants.Length)
            {
                Occupants[index] = passenger;
            }
           
        }

        public double GetCurrentWeight()
        {
            double sum = 0;
            for (int i = 0; i < Occupants.Length; i++)
            {


                if (Occupants[i] != null)
                {
                    sum += Occupants[i].GetWeight();

                }


            }
            return sum;
        }

        public Boolean IsOverMaxCapacity()
        {
            if(GetCurrentWeight()>MaxWeight)
            {
                return true;
            }

            else
            {
                return false;
            }

        }  



        }

    }

