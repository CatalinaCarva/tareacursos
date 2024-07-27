using System;

namespace GestionReciclaje
{
    internal class ProgramaReciclaje
    {
        public static void Main(string[] args)
        {
            string usuario;
            string opcion = "s";

            Console.WriteLine("Ecologia Verde");
            Console.Write("Por favor, digite su nombre : ");
            usuario = Console.ReadLine();


            do
            {
                Console.WriteLine("\ngracias por ingresar, {0}. digita una opcion", usuario);
                Console.WriteLine("1.¿Que materiales puedo reciclar?");
                Console.WriteLine("2. consejos para aprender a reciclar ");
                Console.WriteLine("3. Beneficios del reciclaje ");
                Console.WriteLine("4. ¿Como usar la ecologia verde? ");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");
                string? v = Console.ReadLine();
                string seleccion = v;

                switch (seleccion)
                {
                    case "1":
                        MostrarImportancia();
                        break;
                    case "2":
                        MostrarProceso();
                        break;
                    case "3":
                        MostrarBeneficios();
                        break;
                    case "4":
                        MostrarParticipacion();
                        break;
                    case "5":
                        Console.WriteLine("Saliendo del sistema...");
                        opcion = "n";
                        break;
                    default:
                        Console.WriteLine("Opción no válida, por favor intente nuevamente.");
                        break;
                }

                if (opcion != "n")
                {
                    Console.WriteLine("¿desea continuar? ");
                    opcion = Console.ReadLine ().ToLower();
                }

            } while (opcion != "n");

            Console.WriteLine("espero esta informacion te haya sido de ayuda");
        }

        static void MostrarImportancia()
        {
            Console.WriteLine("\n¿Que materiales puedo reciclar?:");
            Console.WriteLine("En el hogar, algunos de los materiales que se pueden reciclar y reutilizar incluyen:Papel,Metal, Plástico");
        }

        static void MostrarProceso()
        {
            Console.WriteLine("\n: consejos para aprender a reciclar");
            Console.WriteLine(" Reservar un espacio en casa para reciclaje es el primer paso que hacer para reciclar en casa. Puede parecer evidente, pero andar con bolsas y sin un espacio claro para reciclar puede entorpecer el proceso. Hazte con un sencillo juego de cubos y colócalos de la forma más cómoda para que reciclar no te resulte un esfuerzo extra.");
        }

        static void MostrarBeneficios()
        {
            Console.WriteLine("\n Beneficios del reciclaje:");
            Console.WriteLine("ahorrar materias primas, energía, agua y reducir las emisiones de gases de efecto invernadero ¡AYUDEMOS AL PLANETA!.");
        }

        static void MostrarParticipacion()
        {
            Console.WriteLine("\n¿Como usar la ecologia verde?");
            Console.WriteLine("Como primer paso La siembra de variedades locales y la implementación del control biológico de plagas promueven la biodiversidad y reducen la dependencia de pesticidas químicos.");
            Console.WriteLine("Reducción de Residuos: Cuanto menos consumimos, menos residuos generamos. Esto reduce la presión sobre nuestros vertederos y la explotación de recursos.");
            Console.WriteLine("Reutilización: Extender la vida útil de productos y materiales reduce la necesidad de producir nuevos, ahorrando recursos y energía.");
            Console.WriteLine("Reciclaje: reciclaje convierte desechos en nuevos productos, evitando la sobreexplotación de recursos naturales y reduciendo la contaminación. Descubre como reciclar en casa.");
        }
    }
}
