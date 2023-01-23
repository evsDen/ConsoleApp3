using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Pole  
    {
        Random random = new Random();



        int[][] pole;
        public static int[] gryadka;
        public static string[] plant_Name_;

        int[] Gryad;

        public int[] Gryadka
        {
            set { gryadka = value; }
        }

       

        public string[] Plant_Name
        {
            set { plant_Name_ = value; }
        }
        public Pole(int[] Gryad_, string[] Name )
        {

            this.Plant_Name = Name;
            this.Gryadka = Gryad_;
            pole= new int[3][];

            for (int i = 0; i < pole.Length; i++)
            {
                if (i == 0)
                {
                    pole[0] = new int[3];
                }
                if (i == 1)
                {
                    pole[1] = new int[6];
                }
                if (i == 2)
                {
                    pole[2] = new int[8];
                }
            }
           // Gryad = new int[Gryad_[]];   
        }

        public void Zasev ()
        {            
                            
                    for (int j = 0;j < gryadka[0]; j++)
                    {
                    pole[0][j] = random.Next(2, 4) ;
                    }              
            
                for (int j = 0; j < gryadka[1]; j++)
                {
                    pole[1][j] = random.Next(2, 5);
                }
           
                for (int j = 0; j < gryadka[2]; j++)
                {
                    pole[2][j] = random.Next(1, 3);
                }
           
        }
        public void Sbor()
        {
            for (int i = 0; i < pole.Length; i++)
            {
                for (int j = 0; j < pole[i].Length; j++)
                {
                    pole[i][j] = 0;
                }
            }       
            
        }

        public void Zasev(int Col)  
        {
             Gryad = new int[gryadka[Col]];
            if (Gryad.Length == 3)
                for (int j = 0; j < Gryad.Length; j++)
                {
                    Gryad[j] = random.Next(2, 4);
                }
            if (Gryad.Length == 6)
                for (int j = 0; j < Gryad.Length; j++)
                {
                    Gryad[j] = random.Next(2, 5);
                }
            if (Gryad.Length == 8)
                for (int j = 0; j < Gryad.Length; j++)
                {
                    Gryad[j] = random.Next(1, 3);
                }
            for (int i = 0; i < Gryad.Length; i++)
            {
                Console.WriteLine(plant_Name_[Col] + " весом: " + Gryad[i]);
            }

        }
        public void Sbor(int Col)
        {

            
            for (int i = 0; i < gryadka[Col]; i++)
            {
                 Gryad[i] = 0;
                
            }
            for (int i = 0; i < Gryad.Length; i++)
            {
                Console.WriteLine(plant_Name_[Col] + " весом: " + Gryad[i]);
            }

        }
        public void AllPole()
        {
            for(int i = 0; i < pole.Length; i++)
            {
                for(int j = 0; j < pole[i].Length; j++)
                {
                    Console.WriteLine(plant_Name_[i] + " весом: " + pole[i][j]);
                }
            }
        }

     
    }
}
