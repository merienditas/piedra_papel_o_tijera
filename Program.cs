using System;

namespace EJERCICIO_ENUMERADOS
{
    enum PiedraPapelTijera
    {
        piedra,
        papel,
        tijeras
    }
    class Program
    {
        static void Main(string[] args)
        {
            // necesitamos dos personas, y saber quién de los dos jugadores gana

            Console.WriteLine("Introduzca el nombre del primer jugador: ");
            string usuario1 = Console.ReadLine();
            Console.WriteLine("Introduzca el nombre del segundo jugador: ");
            string usuario2 = Console.ReadLine();

            // necesitamos preguntar que quieren coger, si piedra papel o tijera.

           /* var juego = new Random();
            int tiradaJuego = juego.Next(0,3); // random y next van juntos */

            // falta que el usuario elija qué desea mostrar al jugar a piedra-papel-tijera

            Console.WriteLine($"Elija una opción, {usuario1}: *SÓLO ESCRIBA EL NÚMERO*  piedra (0), papel (1) o tijera (2). ");
            int respuesta = Int32.Parse(Console.ReadLine());
           
            Console.Clear();
            
            Console.WriteLine($"Elija una opción, {usuario2}: *SÓLO ESCRIBA EL NÚMERO*  piedra (0), papel (1) o tijera (2). ");
            int tiradaJuego = Int32.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Para saber quién ha ganado, pulse ENTER. ");
            Console.ReadLine(); 

            if ((tiradaJuego == 0) && (respuesta == 0))
            {
                Console.WriteLine($"Ha habido un empate entre {usuario1} y {usuario2}");
            }
            else if ((tiradaJuego == 0) && (respuesta == 1))
            {
                Console.WriteLine($"Gana {usuario1} a {usuario2}");
            }
            else if ((tiradaJuego == 0) && (respuesta == 2))
            {
                Console.WriteLine($"Gana {usuario2} a {usuario1}");
            }

            else if ((tiradaJuego == 1) && (respuesta == 0))
            {
                Console.WriteLine($"Gana {usuario2} a {usuario1}");
            }
            else if ((tiradaJuego == 1) && (respuesta == 1))
            {
                Console.WriteLine($"Ha habido un empate entre {usuario1} y {usuario2}");
            }
            else if ((tiradaJuego == 1) && (respuesta == 2))
            {
                Console.WriteLine($"Gana {usuario1} a {usuario2}");
            }

            else if ((tiradaJuego == 2) && (respuesta == 0))
            {
                Console.WriteLine($"Gana {usuario1} a la máquina");
            }
            else if ((tiradaJuego == 2) && (respuesta == 1))
            {
                Console.WriteLine($"Gana {usuario2} a {usuario1}");
            }
            else if ((tiradaJuego == 2) && (respuesta == 2))
            {
                Console.WriteLine($"Ha habido un empate entre {usuario1} y {usuario2}");
            }

        }
    }
}
