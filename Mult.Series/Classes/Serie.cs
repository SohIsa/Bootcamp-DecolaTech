namespace Mult.Series
{
    public class Serie : EntidadeBase
    {
            //Atributos

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

            //Métodos

        public Serie (int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {       //O eviroment vai pegar a forma como o SO interpreta uma nova linha \n \r
            string retorno = "";
            retorno += "Gênero" + this.Genero + Enviroment.NewLine;
            retorno += "Título" + this.Titulo + Enviroment.NewLine;
            retorno += "Descrição" + this.Descricao + Enviroment.NewLine;
            retorno += "Ano de Início: " + this.Ano;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}