using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_0___Ej5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var documentos = new Dictionary<decimal, string>();
            bool esnumero = false;
            bool sigue = false;
            string sino;
            bool esigual = false;
            while(!sigue)
            {
                string ingreso;
                string nombre;
                decimal dni = 0;
                esnumero = false;
                while (!esnumero)
                {
                    Console.Write("Ingrese el numero de documento:");
                    ingreso = Console.ReadLine();
                    esnumero = decimal.TryParse(ingreso, out dni);



                    Console.WriteLine();
                    foreach (var doc in documentos.Keys)
                    {
                        if (dni == doc)
                        {
                            esigual = true;
                            Console.WriteLine("El documento ingresado ya existe. Por favor ingrese uno valido.");
                            Console.WriteLine();
                            break;
                        }
                        
                    }

                    if (esigual)
                    {
                        esnumero = false;
                        break;
                    }
                    else
                    {
                        Console.Write("Ingrese el nombre:");
                        nombre = Console.ReadLine();


                        documentos.Add(dni, nombre);
                        Console.WriteLine();
                        Console.Write("Desea seguir agregando (si/no):");
                        sino = Console.ReadLine();

                        if (sino == "no")
                        {
                            Console.WriteLine(documentos.Keys);
                            sigue = true;
                        }
                    }
                }
               

            }

        }
    }
}
