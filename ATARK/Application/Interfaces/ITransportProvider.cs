using Domen.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITransportProvider
    {
        Task<ActionResult<IEnumerable<Transport>>> GetAll();
        Task<ActionResult<IEnumerable<Transport>>> FilterByType(string item);
        Task<ActionResult<IEnumerable<Transport>>> FilterByNumber(int item);
        Task<ActionResult<IEnumerable<Transport>>> FilterByCity(string item);


        Task<ActionResult<Transport>> Get(int id);

        Task<int> Post(Transport transport);

        Task Put(Transport transport);

        Task Delete(int id);

    }
}
