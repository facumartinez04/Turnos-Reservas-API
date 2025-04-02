
using DLL.Implementations.Context;
using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Implementations.SQLServer
{
    public class ReservaDLL : IGenericDAO<Reserva>
    {
        public bool Add(Reserva entity)
        {
            try
            {

                using (var context = new ApireservaTurnosContext())
                {
                    context.Reservas.Add(entity);
                    context.SaveChanges();
                }
                return true;
                
            }
            catch (Exception)
            {
                return false;

            }
        }

        public bool Delete(Reserva entity)
        {

            try
            {
                using (var context = new ApireservaTurnosContext())
                {
                    context.Reservas.Remove(entity);
                    context.SaveChanges();
                }

                return true;
                
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
                using (var context = new ApireservaTurnosContext())
                {
                    return context.Reservas.ToList();
                }

            }
            catch (Exception)
            {
                return new List<Reserva>();
            }
        }

        public Reserva GetById(int id)
        {

            try
            {
                using (var context = new ApireservaTurnosContext())
                {
                    return context.Reservas.Where(x => x.IdReserva == id).FirstOrDefault();
                }
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

                using (var context = new ApireservaTurnosContext())
                {
                    context.Reservas.Update(entity);
                    context.SaveChanges();
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
