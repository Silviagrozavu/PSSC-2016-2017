using Models.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    
        public class StudyYearRepository : IRepository<Deanship.StudyYear>
        {
            public IEnumerable<StudyYear> List
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public void Add(StudyYear entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(StudyYear entity)
            {
                throw new NotImplementedException();
            }

            public StudyYear FindById(Guid Id)
            {
                throw new NotImplementedException();
            }

            public void Update(StudyYear entity)
            {
                throw new NotImplementedException();
            }
        }
    }

