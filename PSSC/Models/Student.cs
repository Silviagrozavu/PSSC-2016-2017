using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  
        class Student

        {
            string nume;
            string prenume;
            int anstudiu;
            int nrmatricol;
            string cnp;

            public string Nume
            {
                get { return nume; }
                set { nume = value; }
            }
            public string Prenume
            {
                get { return prenume; }
                set { prenume = value; }
            }
            public int AnStudiu
            {
                get { return anstudiu; }
                set { anstudiu = value; }
            }
            public int NrMatricol
            {
                get { return nrmatricol; }
                set { nrmatricol = value; }
            }
            public string Cnp
            {
                get { return cnp; }
                set { cnp = value; }
            }
            public Student(string nume, string prenume, int an_studiu, int nr_matricol, string cnp)
            {
                this.nume = nume;
                this.prenume = prenume;
                this.anstudiu = an_studiu;
                this.nrmatricol = nr_matricol;
                this.cnp = cnp;
            }
        }


    }


