using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApparreglos
{
    class Materia
    {
        private String nombre;
        private String profesor;
        private int matricula;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Profesor
        {
            get
            {
                return profesor;
            }
            set
            {
                profesor = value;
            }
        }
        public int Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public Materia ()
        {
          nombre= "" ;
          profesor = "";
          matricula = 0 ;
    }
    public Materia(string nombre, string profesor, int matricula)
    {
        this.nombre = nombre;
        this.profesor = profesor;
        this.matricula = matricula;
    }
        public override string ToString()
        {
            return nombre  +  " "  +  profesor  +  " "  +  matricula + " " ;
        }
     }
}
