using System;

namespace Lab2_ClassMeasurements
{
    class Program
    {

        static void Main(string[] args)

        {

            while (true)
            {
                Console.WriteLine("Enter Length ");
                decimal lengthSide = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter Width");
                decimal widthSide = Convert.ToDecimal(Console.ReadLine());

                decimal area = lengthSide * widthSide;
                Console.WriteLine("Area:" + area);

                decimal perimeter = 2 * (lengthSide + widthSide);
                Console.WriteLine("Perimeter:" + perimeter);


                Console.WriteLine("Continue? (Y/N)");
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
               {
                    continue;
                }

                else
                {
                    Console.WriteLine("See You Next Time!");
                    Console.ReadLine();
                    break; 
                }
                
                
                
              
            

            }
                   
            
            
     
            }
        }

        }


        

        
    

