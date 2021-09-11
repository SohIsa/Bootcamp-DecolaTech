using System.Collections.Generic;

namespace Mult.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();              //o método da interface que retorna uma lista de T
        T RetornaPorId(int id);      //retorna o T do id
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}