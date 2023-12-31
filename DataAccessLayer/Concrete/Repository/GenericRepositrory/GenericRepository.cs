﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer.Concrete.Repository.GenericRepositrory
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Delete(T t)
        {
            
            using var context = new InsuranceContext();
            context.Remove(t);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            using var context = new InsuranceContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {

            using var context = new InsuranceContext();
            
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new InsuranceContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new InsuranceContext();
            context.Update(t);
            context.SaveChanges() ;
        }
    }
}
