using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    
        class Decanat
        {
            List<Materie> materie = new List<Materie>();
            List<Profesor> profesori = new List<Profesor>();
            List<Student> studenti = new List<Student>();

            private List<Materie> Materie
            {
                get { return materie; }
                set { materie = value; }
            }
            private List<Profesor> Profesori
            {
                get { return profesori; }
                set { profesori = value; }
            }
            private List<Student> Studenti
            {
                get { return studenti; }
                set { studenti = value; }
            }
            public Decanat(List<Materie> materie, List<Profesor> profesori, List<Student> studenti)
            {
                this.materie = Materie;
                this.profesori = profesori;
                this.studenti = studenti;
            }
        }
}
