using BLL.Interfaces;
using DLL;
using DLL.Implementations.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class ServicioBLL : IGenericBLL<Servicio>
    {
        ServicioDLL ServicioDLL = new ServicioDLL();
        public bool Add(Servicio entity)
        {
            try
            {
                ServicioDLL.Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                Servicio Servicio = ServicioDLL.GetById(id);
                ServicioDLL.Delete(Servicio);
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
                return ServicioDLL.GetAll();
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
                return ServicioDLL.GetById(id);
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
                ServicioDLL.Update(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
