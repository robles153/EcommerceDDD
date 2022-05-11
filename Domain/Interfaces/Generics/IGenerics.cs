using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public interface IGenerics<T> where T : class
    {
        Task Add(T objeto);
        Task Update(T objeto);
        Task Delete(T ojeto);

        Task<T> GetEntityById(int id);
        Task<List<T>> List();

    }
}
