using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
   public class MenuPrincipal
    {
        public static void MenuPrinci()
        {
            try
            {
                Console.Clear();
                int menu = 0;

                Console.WriteLine("\nOpcion 1   \n Opcion 2 \n Opcion 3");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                    case 4:
                       
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar nuestro sistema");
                        Console.ReadKey();
                        break;


                    default:
                        Console.WriteLine("Debe seleccionar una de las opciones disponible");
                        Console.ReadKey();

                        break;
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe seleccionar una de las opciones disponible");
                Console.ReadKey();





            }
        }
    }
}