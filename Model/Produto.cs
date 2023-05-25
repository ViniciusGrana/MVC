namespace Console_MVC.Model
{
    public class Produto
    {
        public int Codigo { get; set;}
        public string Nome{get;set;}
        public float Preco{get;set;}
// caminho da pasta e do arquivo definido
        private const string PATH = "Database/Produto.csv";
// criar um construtor
        public Produto()
        {
            // obter o caminho da pasta 
           string pasta =  PATH.Split("/")[0];

    // se nao existir uma pasta database, entao cria-se uma
           if (!Directory.Exists(pasta))
           {
            Directory.CreateDirectory(pasta);
           }
    // se não existir um arquivo csv no caminho, então cria-se
           if (!File.Exists(PATH))
           {
            File.Create(PATH);
           }
        }
        public List<Produto> Ler()
        {
            // Instanciar uma lista de Produto
            List<Produto> Produtos  = new List<Produto>();
        // array string que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                Produto p = new Produto();

                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                Produtos.Add(p);

            }

            return Produtos;
        }
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }
        public void Inserir(Produto p)
        {
            string[] linhas = {PrepararLinhasCSV(p)};

            File.AppendAllLines(PATH, linhas);
        }
    }
}