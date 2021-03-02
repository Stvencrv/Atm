using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class Dispensacion
    {

        public int cant;
        MenuPrincipal menu;
        public Dispensacion (int cant)
        {
            this.cant = cant;

        }
        public void metodo1()
        {
            int cont = 0, cont1 = 0;
            while (cant != 0 && cant >= 500)
            {
                cont++;
                cant = cant - 500;
            }
            while (cant != 0 && cant >= 100)
            {
                cont1++;
                cant = cant - 100;
            }

            Console.WriteLine("\nBilletes Recibidos (500): " + cont);
            Console.WriteLine("Billetes recibidos (100): " + cont1);
            Console.ReadKey();
            menu = new MenuPrincipal();
            menu.MenuPrinci();
        }


    }

        public void metodo2()
        {

        }

        public void metodo3()
        {


        }

    }
}
