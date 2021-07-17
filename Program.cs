using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment_2
{
    class Program
    {


        static int[] id = new int[50];
        static string[] model = new String[50];
        static int[] ecapacity = new int[50];
        static int[] pcapacity = new int[50];

        static int nextindex = 0;

        static void RegisterAircraft()
        {
            int idinput;
            string modelinput;
            int ecapacityinput;
            int pcapacityinput;

            Console.WriteLine("Please enter an Plane ID:");
            idinput = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter model:");
            modelinput = Console.ReadLine();


            Console.WriteLine("Please enter Engine Capacity(kW):");
            ecapacityinput = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter Passenger Capacity:");
            pcapacityinput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < model.Length; i++)
            {
                if (model[i] == null)
                {
                    nextindex = i;
                    break;
                }

            }
            id[nextindex] = idinput;
            model[nextindex] = modelinput;
            ecapacity[nextindex] = ecapacityinput;
            pcapacity[nextindex] = pcapacityinput;

            Menu();

        }

      

        static void Searchplaneid()
        {
            int search = 0;

            Console.WriteLine("PlaneID");
            search = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < id.Length; i++) // search from planeid array
            {
                if (search == id[i])
                {

                    Console.WriteLine("Plane id:"+id[i] + "     " + "Model:"+ model[i] + "     " +"Engine Capacity:"+ ecapacity[i] + "     " +"Passenger Capacity:"+ pcapacity[i]); ;
                    
                }

            }

            Menu();
           
        }

       
     

       
      

      

        static void sortaircraft() //Bubble Sort(Sorting the Aircrafts by ascending order)
        {
            string tem;
            int temp;

            for(int j=0; j< nextindex -1; j++)
            {
            for (int i=0; i<nextindex -1 -j; i++)
                {
                    if(id[i].CompareTo(id[i+1]) > 0)
                    {
                        temp = id[i];
                        id[i] = id[i + 1];
                        id[i + 1] = temp;


                        tem = model[i];
                        model[i] = model[i + 1];
                        model[i + 1] = tem;


                        temp = ecapacity[i];
                        ecapacity[i] = ecapacity[i + 1];
                        ecapacity[i + 1] = temp;


                        temp = pcapacity[i];
                        pcapacity[i] = pcapacity[i + 1];
                        pcapacity[i + 1] = temp;
                    }
                }
            }
            //display sorting details
            for (int i=0; i<nextindex; i++ )
            {
                Console.WriteLine("Plane id:" + id[i] + "     " + "Model:" + model[i] + "     " + "Engine Capacity:" + ecapacity[i] + "     " + "Passenger Capacity:" + pcapacity[i]); 

            }

            Menu();
        }

        static void Menu()
        {
            int Option = 0;
            Console.WriteLine("Enter an Option   1-Register Aircrafts      2-Searchaircrafts      3-Sortaircrafts      4-Exit ");

            Option = Convert.ToInt32(Console.ReadLine());

            if (Option == 1)
            {
                RegisterAircraft();
            }
            else if (Option == 2)
            {
                Searchplaneid();

            }
            else if (Option == 3)
            {
                sortaircraft();
            }
            else if (Option == 4) //exit from the program
            {
                System.Environment.Exit(1);
            }

        }

        static void Main(string[] args)
        {
            Menu();
            
            Console.ReadKey(true);
        }
    }
}
