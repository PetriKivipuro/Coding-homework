using System;
using System.Collections.Generic;

namespace Exercise
{
    public class IOU
    {

        private Dictionary<string, int> velka;

        public IOU()
        {
            this.velka = new Dictionary<string, int>();
        }


        public void ChangeDebt(string toWhom, int amount)
        {
            if (this.velka.ContainsKey(toWhom))
            {
                if (velka[toWhom] + amount >= 0)
                {
                    velka[toWhom] += amount;
                }
                else
                {
                    velka[toWhom] = 0;
                }
            }
            else if (amount >= 0)
            {
                velka.Add(toWhom, amount);
            }
            else
            {
                velka.Add(toWhom, 0);
            }
        }


        public int HowMuchDoIOweTo(string toWhom)
        {
            if (this.velka.ContainsKey(toWhom))
            {
                return this.velka[toWhom];
            }
            else
            {
                return 0;
            }
        }
    }
}
