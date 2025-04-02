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
    public class TipoIdentificacionBusiness : IGenericBLL<TipoIdentificacion>
    {

        TipoIdentificacionDLL TipoIdentificacionDLL = new TipoIdentificacionDLL();
        public bool Add(TipoIdentificacion entity)
        {

            return TipoIdentificacionDLL.Add(entity);
        }

        public bool Delete(TipoIdentificacion entity)
        {
            return TipoIdentificacionDLL.Delete(entity);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoIdentificacion> GetAll()
        {

            return TipoIdentificacionDLL.GetAll();
        }

        public TipoIdentificacion GetById(int id)
        {
            return TipoIdentificacionDLL.GetById(id);
        }

        public bool Update(TipoIdentificacion entity)
        {
            return TipoIdentificacionDLL.Update(entity);
        }
    }
}
