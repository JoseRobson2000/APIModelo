namespace APIModelo.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NumeroCelular { get; set; }
        public DateOnly DataNascimento { get; set; }

        //Método contendo todos os dados
        public List<Pessoa> Dados()
        {

            var ListaPessoa = new List<Pessoa>();

            var vPessoa1 = new Pessoa();
            vPessoa1.Id = 1;
            vPessoa1.Nome = "João";

            var vPessoa2 = new Pessoa();
            vPessoa2.Id = 2;
            vPessoa2.Nome = "Ana";

            var vPessoa3 = new Pessoa();
            vPessoa3.Id = 2;
            vPessoa3.Nome = "Maria";

            ListaPessoa.Add(vPessoa1);
            ListaPessoa.Add(vPessoa2);
            ListaPessoa.Add(vPessoa3);

            return ListaPessoa;
        }
    }
}
