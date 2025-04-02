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
    public class ClienteBusiness : IGenericBLL<Cliente>
    {

        ClienteDLL ClienteDLL = new ClienteDLL();

        public bool Add(Cliente entity)
        {

            return ClienteDLL.Add(entity);
        }

        public bool Delete(int id)
        {

            Cliente clientBuscado = ClienteDLL.GetById(id);
            if (clientBuscado == null)
            {
                return false;
            }


            return ClienteDLL.Delete(clientBuscado);
        }

        public List<Cliente> GetAll()
        {


            return ClienteDLL.GetAll();

        }

        public Cliente GetById(int id)
        {
            return ClienteDLL.GetById(id);
        }

        public bool Update(Cliente entity)
        {
            return ClienteDLL.Update(entity);
        }
    }
}
