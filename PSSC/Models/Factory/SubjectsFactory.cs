using Models.Generics;
using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Models.Factory
{
    class SubjectsFactory
    {
        public static readonly SubjectsFactory Instance = new SubjectsFactory();
      


        private SubjectsFactory()
        {

        }

        public Subject.Subject CreeazaDisciplina(string nume)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentNullException>(
                    nume.Length >= 2 && nume.Length <= 50,
                    "Numele disciplinei trebuie sa contina intre 2 si 50 de caractere.");

            var subject = new Subject.Subject();

            return subject;
        }
    }
}

