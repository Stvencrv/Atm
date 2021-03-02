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
            int e = 0, a = 0;
            while (cant != 0 && cant >= 500)
            {
                e++;
                cant = cant - 500;
            }
            while (cant != 0 && cant >= 100)
            {
                a++;
                cant = cant - 100;
            }

            Console.WriteLine("\nBilletes de 500 Entregados): " + e);
            Console.WriteLine("Billetes de 100 Entregados : " + a);
            Console.ReadKey();
            menu = new MenuPrincipal();
            menu.MenuPrinci();
        }



        public void metodo2()
        {
            int e = 0, a = 0;
            int validar = cant / 2;
            if (cant > 100 && validar % 100 == 0)
            {
                while (cant != 0 && cant >= 1000)
                {
                    e++;
                    cant = cant - 1000;
                }
                while (cant != 0 && cant >= 200)
                {
                    a++;
                    cant = cant - 200;
                }

                Console.WriteLine("\nBilletes de 1000 entregados : " + e);
                Console.WriteLine("Billetes de 200 entregados : " + a);
                Console.ReadKey();
                menu = new MenuPrincipal();
                menu.MenuPrinci();
            }
            else
            {
                Console.WriteLine("El cajero no esta configurado para ese billete");
                Console.ReadKey();
                menu = new MenuPrincipal();
                menu.MenuPrinci();
            }

        }
    

    public void metodo3()
    {
        int e = 0, a = 0, i = 0, o = 0;
        while (cant != 0 && cant >= 1000)
        {
            e++;
            cant = cant - 1000;
        }

        while (cant != 0 && cant >= 500)
        {
            a++;
            cant = cant - 500;
        }
        while (cant != 0 && cant >= 200)
        {
            i++;
            cant = cant - 200;
        }
        while (cant != 0 && cant >= 100)
        {
            o++;
            cant = cant - 100;
        }

        Console.WriteLine("\nBilletes de 1000 entregados : " + e);
        Console.WriteLine("Billetes de 500 entregados  " + a);
        Console.WriteLine("Billetes de 200 entregados : " + i);
        Console.WriteLine("Billetes de 100 entregados : " + o);
        Console.ReadKey();
        menu = new MenuPrincipal();
        menu.MenuPrinci();
    }
    }
}




    

       

