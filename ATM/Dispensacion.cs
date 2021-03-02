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



        public void metodo2()
        {
            int cont = 0, cont1 = 0;
            int validar = cant / 2;
            if (cant > 100 && validar % 100 == 0)
            {
                while (cant != 0 && cant >= 1000)
                {
                    cont++;
                    cant = cant - 1000;
                }
                while (cant != 0 && cant >= 200)
                {
                    cont1++;
                    cant = cant - 200;
                }

                Console.WriteLine("\nBilletes recibidos (1000): " + cont);
                Console.WriteLine("Billetes recibidos(200): " + cont1);
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
        int cont = 0, cont1 = 0, cont2 = 0, cont3 = 0;
        while (cant != 0 && cant >= 1000)
        {
            cont++;
            cant = cant - 1000;
        }

        while (cant != 0 && cant >= 500)
        {
            cont1++;
            cant = cant - 500;
        }
        while (cant != 0 && cant >= 200)
        {
            cont2++;
            cant = cant - 200;
        }
        while (cant != 0 && cant >= 100)
        {
            cont3++;
            cant = cant - 100;
        }

        Console.WriteLine("\nPapeletas devueltas (1000): " + cont);
        Console.WriteLine("Papeletas devueltas (500): " + cont1);
        Console.WriteLine("Papeletas devueltas (200): " + cont2);
        Console.WriteLine("Papeletas devueltas (100): " + cont3);
        Console.ReadKey();
        menu = new MenuPrincipal();
        menu.MenuPrinci();
    }
    }
}




    

       

