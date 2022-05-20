using PepitoSchool.Domain.Entities;
using PepitoSchool.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Infrastructure.Repository
{
    public class EstudianteRepository : IEstudiante
    {

        IPepitoSchoolContext pepe;
        public void Create(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto estudiante no puede ser null.");
                }

                pepe.Estudiantes.Add(t);

                pepe.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto Estudiante no puede ser null.");
                }

                Estudiante estudiante = FindById(t.Id);
                if (estudiante == null)
                {
                    throw new Exception($"El objeto con estudiante no existe.");
                }

                pepe.Estudiantes.Remove(estudiante);
                int result = pepe.SaveChanges();

                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Estudiante FindById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new Exception($"El id {id} no puede ser menor o igual a cero.");
                }

                return pepe.Estudiantes.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                throw;
            }
        }

        public List<Estudiante> GetAll()
        {
            return pepe.Estudiantes.ToList();
        }

        public int Media(int id)
        {
            try
            {

                Estudiante estudiante = FindById(id);


                if (estudiante == null)
                {
                    throw new ArgumentNullException("El objeto Estudiante no puede ser null.");
                }
                int promedio = (estudiante.Matematica + estudiante.Contabilidad + estudiante.Programación + estudiante.Estadistica) / 4;
                return promedio;

            }
            catch (Exception)
            {

                return 0;

            }
        }

        public int Update(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto asset no puede ser null.");
                }

                Estudiante estudiante = FindById(t.Id);
                if (estudiante == null)
                {
                    throw new Exception($"El objeto asset con id {t.Id} no existe.");
                }

                estudiante.Nombres = t.Nombres;
                estudiante.Apellidos = t.Apellidos;
                estudiante.Phone = t.Phone;
                estudiante.Direccion = t.Direccion;
                estudiante.Correo = t.Correo;
                estudiante.Matematica = t.Matematica;
                estudiante.Contabilidad = t.Contabilidad;
                estudiante.Programacion = t.Programacion;
                estudiante.Estadistica = t.Estadistica;

                pepe.Estudiantes.Update(estudiante);
                return pepe.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
