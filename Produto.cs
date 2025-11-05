namespace GeradorCodigoDeBarras
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarras { get; set; }



        public Produto(string nome, string codigo)
        {
            Nome = nome;
            Codigo = codigo;

        }

        public Produto(string nome, string codigo, string codigoBarras)
        {
            Nome = nome;
            Codigo = codigo;
            CodigoBarras = codigoBarras;
        }

        public Produto()
        {
        }

        public bool ValidaCodigo(out string mensagemErro)
        {
            if (string.IsNullOrEmpty(Codigo))
            {
                mensagemErro = "Código não pode ser vazio!";
                return false;
            }

            if (Codigo.Length <= 0)
            {
                mensagemErro = "Código de barras deve ser maior que zero!";
                return false;
            }

            else
            {
                mensagemErro = "";
                return true;
            }
        }






    }
}
