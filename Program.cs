using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApparreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Materia[] arreglomaterias = new Materia[5];
            for (int i = 0; i < arreglomaterias.Length; i++) ;
            {
                int i = 0;
                arreglomaterias[i] = new Materia();
                Console.WriteLine("nombre: ");
                arreglomaterias[i].Nombre = Console.ReadLine();
                Console.WriteLine("profesor: ");
                arreglomaterias[i].Profesor = Console.ReadLine();
                Console.WriteLine("matricula: ");
                arreglomaterias[i].Matricula = Console.Read();
            }
            for (int i = 0; i < arreglomaterias.Length; i++) ;
            {
                Console.WriteLine(arreglomaterias[0].ToString());
            }
            Console.ReadKey();
        }
    }
}
