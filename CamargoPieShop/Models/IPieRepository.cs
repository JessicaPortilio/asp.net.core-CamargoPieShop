using BethanysPieShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();// IPieRepository é uma interface de um único método: GetPieByID, que como o nome sugere, obtém um enumerador, um objeto que implementa a interface IPieRepository.
        Pie GetPieByID(int pieId);
    }
}
