using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class plants
    {
        
        string[] plant_NameAll;
        int[] plant_ColAll;

      
        public string[] Plant_name
        {
         
            set { plant_NameAll = value; }
        }
        public int[] Plant_Col
        {
            
            set {plant_ColAll = value; }
        }



        public plants(string plant_Name, int plant_Col, string plant_Name2, int plant_Col2, string plant_Name3, int plant_Col3) 
        {
            plant_NameAll = new string[3];
            plant_ColAll = new int[3];
            plant_NameAll[0] = plant_Name;
            plant_ColAll[0] = plant_Col;
            plant_NameAll[1] = plant_Name2;
            plant_ColAll[1] = plant_Col2;
            plant_NameAll[2] = plant_Name3;
            plant_ColAll[2] = plant_Col3;
        }

        public int[] Semena() 
        {
            return plant_ColAll;
        }

        public string[] Name()
        {
            return plant_NameAll;
        }
                
    }
}
