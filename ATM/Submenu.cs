using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class Submenu
    {
        int op = 0;
        public void SubMenu()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("---------Opciones---------\n1. Papeletas de 200 y 1000\n2. Papeletas de 100 y 500" +
                    "\n3. Metodo eficiente(viene por defecto)\n\nSeleccione una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El modo de dispensacion se ha cambiado con exito");
                        op = 1;
                        break;
                    case 2:
                        Console.WriteLine("El modo de dispensacion se ha cambiado con exito");
                        op = 2;
                        break;
                    case 3:
                        Console.WriteLine("El modo de dispensacion se ha cambiado con exito");
                        op = 3;
                        break;
                    default:
                        Console.WriteLine("\nError, Esa opcion no es valida");
                        Console.ReadKey();
                        SubMenu();
                        break;
                }
                Console.ReadKey();
                SubMenu();
            }
            catch (Exception)
            {
                Console.WriteLine("\nError, Esa opcion no es valida");
                Console.ReadKey();
                SubMenu();
            }
        }
    }
}
