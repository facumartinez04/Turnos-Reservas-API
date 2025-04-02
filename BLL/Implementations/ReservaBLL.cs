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
    public class ReservaBLL : IGenericBLL<Reserva>
    {

        ReservaDLL ReservaDLL = new ReservaDLL();
        public bool Add(Reserva entity)
        {
            try
            {
                return ReservaDLL.Add(entity);
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

                Reserva reserva = ReservaDLL.GetById(id);

                return ReservaDLL.Delete(reserva);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Reserva> GetAll()
        {
            try
            {
                return ReservaDLL.GetAll();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Reserva GetById(int id)
        {
            try
            {
                return ReservaDLL.GetById(id);
            }
            catch (Exception)
            {
                return null;
            }   
        }

        public bool Update(Reserva entity)
        {
            try
            {
                return ReservaDLL.Update(entity);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
