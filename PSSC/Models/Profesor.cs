using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   

        class Profesor
        {
            List<Materie> materie = new List<Materie>();
            List<Student> studenti = new List<Student>();

            string nume_profesor;

            public string Nume_profesor
            {
                get { return nume_profesor; }
                set { nume_profesor = value; }
            }

            public Profesor(string numeProfesor)
            {
                this.nume_profesor = numeProfesor;

            }
        }
    }

