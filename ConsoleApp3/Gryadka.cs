using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    
   internal class Gryadka : Pole
    {
        Random random= new Random();

        string[] plant_Name;
        int[] gryad;       

        public string[] Plant_Name 
        {
            set { plant_Name = value; }
        }
        public int[] Gryad
        {
            set { gryad = value; }
        }
        public Gryadka(int[] Col, string[] name) : base(gryadka, plant_Name_)
        {
            this.Plant_Name = name;
            gryad = Col;
            
        }

    }
}
