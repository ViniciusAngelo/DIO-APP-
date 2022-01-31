using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
      List <T> lista();

      T RetornaPorId(int id);

      void insere(T entidade);

      void Exclui(int id);

      void Atualiza (int id, T intidade);

      int ProximoId();   
    }
}