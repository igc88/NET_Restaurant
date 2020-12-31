using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Restaurant {

    class Carta {
        private Dictionary<string, int> platos = new Dictionary<string, int>() {
            {"Tostadas", 5},
            {"Zumo", 7 },
            {"Macarrones",15 },
            {"Lentejas", 12 },
            {"Hamburguesa", 11 },
            {"Escudella", 25 },
            {"Manzana",3 },
            {"Pera", 4 }
        };

        public void init() {
            int billete5, billete10, billete20, billete50, billete100, billete200, billete500;

            double precioTotal = 0;

            string[] menu = new string[platos.Count];
            int[] precios = new int[platos.Count];

            bool continueOrder = true;

            List<string> userOrder = new List<string>();

            Console.WriteLine("Menu Restaurante");
            Console.WriteLine("---------------------");

            for (int i = 0; i < platos.Count; i++) {
                menu[i] = platos.ElementAt(i).Key;
                precios[i] = platos.ElementAt(i).Value;

                Console.WriteLine("{0} - {1} eur", menu[i], precios[i]);
            }

            whitespace();

            while (continueOrder) {
                Console.WriteLine("¿Qué desea?");
                string newPlato = Console.ReadLine();

                try {                    
                    int precio = platos[newPlato];
                    precioTotal += precio;
                    userOrder.Add(newPlato);
                } catch (KeyNotFoundException ex) {
                    Console.WriteLine(ex.Message);
                }                

                bool correctOption = false;

                while (!correctOption) {
                    Console.WriteLine("¿Algo más? (1: Si - 0: No)");
                    int opcion = int.Parse(Console.ReadLine());
                    if (opcion == 0) {
                        continueOrder = false;
                        correctOption = true;
                    } else if (opcion != 1) {
                        throw new Exception("Debe introducir una opción correcta");
                    } else {
                        correctOption = true;
                    }
                }
            }

            whitespace();
            Console.WriteLine("Revisión del pedido:");
            whitespace();

            for (int i = 0; i < userOrder.Count; i++) {
                if (platos.Keys.Contains(userOrder.ElementAt(i))) {
                    Console.WriteLine("{0} - {1}", userOrder.ElementAt(i), platos[userOrder.ElementAt(i)]);
                    
                } else {
                    Console.WriteLine("{0} - {1}", userOrder.ElementAt(i), "El plato especificado no existe");
                }
            }

            whitespace();
            Console.WriteLine("El precio total de su pedido es {0} euros", precioTotal);
        }

        public void whitespace() {
            Console.WriteLine(string.Empty);
        }
    };



}

