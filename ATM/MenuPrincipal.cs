using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
   public class MenuPrincipal
    {
        public  void MenuPrinci()
        {
            try
            {
                Console.Clear();
                int menu = 0;

                Console.WriteLine("Seleccione la opcion deseada \n1,Metodo de dispensacion \n2.Retirar Dinero\n3Salir");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto a retirar: ");
                        int monto = Convert.ToInt32(Console.ReadLine());
                        Dispensacion tipos = new Dispensacion(monto);
                        if (monto % 100 == 0)
                        {
                            switch (op)
                            {
                                case 1:
                                    tipos.metodo1();
                                    break;
                                case 2:
                                    tipos.();
                                    break;
                                case 3:
                                    tipos.();
                                    break;
                                default:
                                    tipos.();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("El cajero no coje este tipo de billetes");
                            Console.ReadKey();
                            MenuPrinci();
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("\nGracias por usar nuestro sistema!!");
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