using System;

namespace PrimeirosPassosNet.estruturaDados
{
    // Primeiro entra e o primeiro que sai - FIFO 
    public class Fila : Musica
    {
        public void Enfileirar(string nomeMusica)
        {
           SetMusicas(ProximoIndiceVazio(),nomeMusica);
        }

        public void Desenfileirar(){
            SetMusicas(ProximoIndicePreenchido(), null);
        }

        public int ProximoIndiceVazio()
        {
            var quantidadeMusicas = Musicas.Length;
            int indiceDisponivel = 0;

            for(int contador = 0; contador <= quantidadeMusicas; contador++)
            {
                if(Musicas[contador] == null){
                    indiceDisponivel = contador;
                    break;
                }
            }

            return indiceDisponivel;
        }

        public int ProximoIndicePreenchido()
        {
            var quantidadeMusicas = Musicas.Length;
            int indiceDisponivel = 0;

            for(int contador = 0; contador <= quantidadeMusicas; contador++)
            {
                if(Musicas[contador] != null){
                    indiceDisponivel = contador;
                    break;
                }
            }

            return indiceDisponivel;
        }
    }
}