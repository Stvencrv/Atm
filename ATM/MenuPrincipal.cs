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
                int opcion = 0;

                Submenu submenus = new Submenu();
                Console.WriteLine("Seleccione la opcion deseada \n1,Metodo de dispensacion \n2.Retirar Dinero\n3Salir");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        submenus.SubMenus();
                        break;
                    case 2:
                        Console.WriteLine("Introduzca la cantidad a sacar: ");
                        int monto = Convert.ToInt32(Console.ReadLine());
                        Dispensacion tipos = new Dispensacion(monto);
                        if (monto % 100 == 0)
                        {
                            switch (opcion)
                            {
                                case 1:
                                    tipos.metodo1();
                                    break;
                                case 2:
                                    tipos.metodo2();
                                    break;
                                case 3:
                                    tipos.metodo3();
                                    break;
                                default:
                                    tipos.metodo3();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Este cajero no acepta este tipo de papeletas");
                            Console.ReadKey();
                            MenuPrinci();
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("\nGracias");
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