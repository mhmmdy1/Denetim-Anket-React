using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        protected readonly Context Context;

        public GenericRepository(Context context)
        {
            this.Context = context;
        }

        public void Delete(T t)
        {
            Context.Remove(t);
            Context.SaveChanges();
        }

        public T GetAccountByEmail(string email)
        {
            return Context.Set<T>().Find(email);
        }

        public T GetByCode(string code)
        {
            return Context.Set<T>().Find(code);
        }

        public T GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public T GetByName(string name)
        {
            return Context.Set<T>().Find(name);

        }

        public List<T> GetListAll()
        {
            return Context.Set<T>().ToList();
        }

        public List<T> GetListByRank()
        {
            return Context.Set<T>().ToList();
        }

        public T GetPersonelInformationByCompanyId(int companyid)
        {
            return Context.Set<T>().Find(companyid);
        }

        public void Insert(T t)
        {
            Context.Add(t);
            Context.SaveChanges();

        }

        public bool IsBlockCodeExist(int facilityId, string code, int blockId = 0)
        {
            throw new NotImplementedException();
        }

        //public bool IsBlockCodeExist(int facilityId, string code, int blockId = 0)
        //{
        //    using var c = new Context();
        //    if()
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool IsCompanyExist(string name)
        {
            if (name == null)
            {
                return false;
            }
            else return true;

        }

        public bool IsEmailExist(string email)
        {
            if(email == null)
            {
                return false;
            }
            return true;
        }

        public void Update(T t)
        {
            Context.Update(t);
            Context.SaveChanges();
        }
      
        public void Save(T t)
        {
            Context.SaveChanges();
        }

        //public T CheckCredentials(string email, string password)
        //{
        //    if (Context.Set<T>().Find(email) == T.)
        //}
    }
}
