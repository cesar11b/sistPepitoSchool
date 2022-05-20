using PepitoSchool.Applications.Interfaces;
using PepitoSchool.Domain.Entities;
using PepitoSchool.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Applications.Services
{
    public class EstudianteService : IEstudianteService
    {


        IEstudiante estudiante;



        public int Media(int id)
        {
            return estudiante.Media(id);
        }

        public void Create(Estudiante t)
        {
            estudiante.Create(t);
        }

        public bool Delete(Estudiante t)
        {
            return estudiante.Delete(t);
        }

        public Estudiante FindById(int id)
        {
            return estudiante.FindById(id);
        }

        public List<Estudiante> GetAll()
        {
            return estudiante.GetAll();
        }

        public int Update(Estudiante t)
        {
            return estudiante.Update(t);
        }
    }
}
