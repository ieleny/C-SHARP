using System;

namespace PrimeirosPassosNet.estruturaDados
{
    public class Musica
    {
        public string[] Musicas =  new string[100];
        public string NomeMusica { get; set; }


        public void SetMusicas(int indice, string musica){
            this.Musicas[indice] = musica;
        }

        public string GetMusicas(int indice, string musica){
            return this.Musicas[indice] = musica;
        }


    }
}