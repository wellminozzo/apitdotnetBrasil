using brasilApi.Dtos;
using BrasilApi.Dtos;

namespace brasilApi.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodosBancos();

        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);
    }
}