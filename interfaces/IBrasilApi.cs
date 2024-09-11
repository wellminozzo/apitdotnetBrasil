using brasilApi.Dtos;
using BrasilApi.Models;

namespace brasilApi.Interfaces
{
    public interface IBrasilApi
    {
      
      Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);

      Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();

      Task<ResponseGenerico<BancoModel>> BuscarBanco(string  codigoBanco);
    }
}