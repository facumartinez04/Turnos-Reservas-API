﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    interface IGenericBLL<T>
    {

        public bool Add(T entity);

        public bool Update(T entity);

        public bool Delete(int id);

        public List<T> GetAll();

        public T GetById(int id);

    }
}
