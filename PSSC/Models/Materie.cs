using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    
        enum TipExamen
        {
            examen, distribuita
        }



        class Materie
        {



            string materie;
            int credite;
            int an_studiu;
            int nota_laborator;
            TipExamen examen;


            List<Student> studenti = new List<Student>();



            public int Nota_laborator
            {
                get { return nota_laborator; }
                set { nota_laborator = value; }
            }

            public string nume_materie
            {
                get { return materie; }
                set { materie = value; }
            }
            public int Credite
            {
                get { return credite; }
                set { credite = value; }
            }
            public int An_studiu
            {
                get { return an_studiu; }
                set { an_studiu = value; }
            }
            public TipExamen Examen
            {
                get { return examen; }
                set { examen = value; }
            }

            public Materie(string materie, int credite, int an_studiu, List<Student> studenti)
            {
                this.materie = materie;
                this.credite = credite;
                this.an_studiu = an_studiu;
                this.studenti = studenti;
            }
        }
    }



