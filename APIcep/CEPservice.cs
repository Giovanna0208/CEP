using System.Threading.Tasks;
using Refit;

namespace APIcep
{
    public interface cepservice
    {
        [Get("/ws/{cep}/json/")]
        Task<cepresponse> Getcep(string cep);
    }
}
