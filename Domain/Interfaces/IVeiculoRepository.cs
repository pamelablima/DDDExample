using Domain.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IVeiculoRepository
    {
        
        Task<string> PostAsync(IVeiculoCommand command);

        void PostAsync();
        void GetAsync();
    }
}
