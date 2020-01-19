using System.Collections.Generic;
using WebApplication17.Models;

namespace WebApplication17.Service
{
    /// <summary>
    /// interfejs
    /// </summary>
    public interface IPizzaService
    {
        List<Pizza> Get();
        int Post(Pizza pizza);
        bool Put(Pizza pizza, int Id);

        public bool Delete(int Id);
    }
}