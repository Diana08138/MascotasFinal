using System;

namespace MascotasApp
{
    // Defini la mascota
    class Mascota
    {
        // Atributos privados
        private string nombre;
        private int edad;
        private string tipo;
        private string sonido;

        // Inician los atributos
        public Mascota(string nom, int ed, string ti, string son)
        {
            nombre = nom;
            edad = ed;
            tipo = ti;
            sonido = son;
        }

        // Getter para edad (getEdad)
        public int GetEdad()
        {
            return edad;
        }

        // Setter para edad (set(int nuevaEdad))
        public void SetEdad(int nuevaEdad)
        {
            edad = nuevaEdad; // Asigna directamente la nueva edad
        }

        // Metodo para mostrar la informacion
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad + " años");
            Console.WriteLine("Tipo: " + tipo);
        }

        // Metodo para emitir el sonido
        public void EmitirSonido()
        {
            Console.WriteLine(nombre + " hace: " + sonido);
        }

        // Metodo para calcular la edad humana
        public int CalcularEdadHumana()
        {
            int factorConversion = 0; // Se inicializa en 0

            // Se usa un switch para determinar el factor de conversion
            switch (tipo.ToLower())
            {
                case "perro":
                    factorConversion = 7;
                    break;
                case "gato":
                    factorConversion = 4;
                    break;
                case "hamster":
                    factorConversion = 25;
                    break;
                default:
                    Console.WriteLine("Mascota no reconocida. Se usara el factor 7 por defecto.");
                    factorConversion = 7;
                    break;
            }
            
            return edad * factorConversion;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Para que el usuario seleccione la mascota deseada
            Mascota oreo = new Mascota("Oreo", 6, "perro", "guau guau ");
            Mascota copo = new Mascota("Copo", 9, "gato", "miau");
            Mascota wallas = new Mascota("Wallas", 2, "hamster", "suic");

            Console.WriteLine("Seleccione una mascota para saber su informacion:");
            Console.WriteLine("1. Oreo (perro)");
            Console.WriteLine("2. Copo (gato)");
            Console.WriteLine("3. Wallas (hamster)");
            
            Console.Write("Ingrese de la opcion valida: ");
            string opcion = Console.ReadLine();

            Console.WriteLine("--------------------");

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("La informacion de Oreo es la siguiente: ");
                    oreo.MostrarInformacion();
                    oreo.EmitirSonido();
                    int edadHumanaOreo = oreo.CalcularEdadHumana();
                    Console.WriteLine("Oreo en edad humana tiene " + edadHumanaOreo + " años.");
                    break;
                case "2":
                    Console.WriteLine("La informacion de Copo es la siguiente: ");
                    copo.MostrarInformacion();
                    copo.EmitirSonido();
                    int edadHumanaCopo = copo.CalcularEdadHumana();
                    Console.WriteLine("Copo en edad humana tiene " + edadHumanaCopo + " años.");
                    break;
                case "3":
                    Console.WriteLine("La informacion de Wallas es la siguiente: ");
                    wallas.MostrarInformacion();
                    wallas.EmitirSonido();
                    int edadHumanaWallas = wallas.CalcularEdadHumana();
                    Console.WriteLine("Wallas en edad humana tiene " + edadHumanaWallas + " años humanos.");
                    break;
                default:
                    Console.WriteLine("La opcion es invalida. Ingrese nuevamente una opcion del 1 al 3.");
                    break;
            }
        }
    }   
}