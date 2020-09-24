using System;
using System.Collections.Generic;
using System.Text;
namespace KtraAnimal
{
    public class Zoo
    {
        public List<Cage> CageList { get; set; }
        public Zoo()
        {
            CageList = new List<Cage>();
        }
        public void AddCage(Cage c)
        {
            CageList.Add(c);
        }
        public void RemoveCage(int CageNumber)
        {
            for (int i = 0; i < CageList.Count; i++)
            {
                if (CageList[i].CageNumber == CageNumber)
                {
                    CageList.RemoveAt(i);
                }
            }
        }
    }
}