
using DLL.Implementations.Context;
using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Implementations.SQLServer
{
    public class ServicioDLL : IGenericDAO<Servicio>
    {
        public bool Add(Servicio entity)
        {
            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    db.Servicios.Add(entity);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool Delete(Servicio entity)
        {
            try
            {

                using (var db = new ApireservaTurnosContext())
                {
                    db.Servicios.Remove(entity);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public List<Servicio> GetAll()
        {
            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    return db.Servicios.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Servicio GetById(int id)
        {
            try
            {

                using (var db = new ApireservaTurnosContext())
                {
                    return db.Servicios.ToList().FirstOrDefault(x => x.IdServicio == id);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(Servicio entity)
        {
            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    db.Servicios.Update(entity);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
