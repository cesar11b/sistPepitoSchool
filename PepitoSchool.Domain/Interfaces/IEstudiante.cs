using PepitoSchool.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Domain.Interfaces
{
    public interface IEstudiante : IRepository<Estudiante>
    {
        int Media(int id);
        Estudiante FindById(int id);


    }
}
