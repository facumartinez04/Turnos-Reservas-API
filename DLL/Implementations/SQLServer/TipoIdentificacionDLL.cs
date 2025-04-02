
using DLL.Implementations.Context;
using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Implementations.SQLServer
{
    public class TipoIdentificacionDLL : IGenericDAO<TipoIdentificacion>
    {
        public bool Add(TipoIdentificacion entity)
        {
            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    db.TipoIdentificacions.Add(entity);
                    db.SaveChanges();
                }
                return true;


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(TipoIdentificacion entity)
        {
            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    db.TipoIdentificacions.Remove(entity);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TipoIdentificacion> GetAll()
        {
            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    return db.TipoIdentificacions.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public TipoIdentificacion GetById(int id)
        {
            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    return db.TipoIdentificacions.ToList().FirstOrDefault(x => x.IdTipoIdentificacion == id);
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(TipoIdentificacion entity)
        {
            try
            {

                using (var db = new ApireservaTurnosContext())
                {
                    db.TipoIdentificacions.Update(entity);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;


            }
        }
    } 
}
