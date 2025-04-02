
using DLL.Implementations.Context;
using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Implementations.SQLServer
{
    public class ClienteDLL : IGenericDAO<Cliente>
    {
        public bool Add(Cliente entity)
        {
            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    db.Clientes.Add(entity);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Cliente entity)
        {
            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    db.Clientes.Remove(entity);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public List<Cliente> GetAll()
        {
            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    return db.Clientes.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Cliente GetById(int id)
        {
            Cliente clienteCheck = new Cliente();

            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    clienteCheck = db.Clientes.Where(x => x.IdCliente == id).FirstOrDefault();
                }

                return clienteCheck;

            }
            catch (Exception ex)
            {
                return clienteCheck;
            }
        }

        public bool Update(Cliente entity)
        {
            try
            {
                using (var db = new ApireservaTurnosContext())
                {
                    db.Clientes.Update(entity);
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
