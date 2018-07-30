using Financeiro.Dominio.Interfaces;
using FInanceiro.Infra;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Repositorio
{
    public class BaseRep<TEntity> : IBase<TEntity> where TEntity : class
    {
        public virtual int Add(params TEntity[] items)
        {
            var context = new Contexto();
            int id = 0;
            foreach (TEntity item in items)
            {
                context.Entry(item).State = EntityState.Added;
                dynamic idT = item;
                id = idT.ID;

            }
            context.SaveChanges();
            return id;
        }

        public async Task<List<TEntity>> GetAll()
        {
            var list = new Contexto().Set<TEntity>();
            return await list.ToListAsync();
        }

        public void Remove(params TEntity[] items)
        {
            var context = new Contexto();
            foreach (TEntity item in items)
            {
                context.Entry(item).State = EntityState.Deleted;
            }
            context.SaveChanges();
        }

        public void Update(params TEntity[] items)
        {
            var context = new Contexto();
            foreach (TEntity item in items)
            {
                context.Entry(item).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }

}
