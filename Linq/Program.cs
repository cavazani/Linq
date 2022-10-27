namespace Linq {
    class Program 
    {
        static void Main(string[] args) 
        {

            var listaProdutos = new List<Produto>() 
            {
                new Produto{Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
                new Produto{Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 1},
                new Produto{Id = 3, CategoriaId = 1, Nome = "VideoGame", Status = true, Valor = 99},
                new Produto{Id = 4, CategoriaId = 1, Nome = "TV", Status = true, Valor = 33},
                new Produto{Id = 5, CategoriaId = 1, Nome = "Maquina", Status = false, Valor = 22},
                new Produto{Id = 6, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 1030},
                new Produto{Id = 7, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 44},
                new Produto{Id = 8, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 232},
                new Produto{Id = 9, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 23}
            };

            var listaCategorias = new List<Categoria>() 
            {
                new Categoria{id = 1, Status = true, Nome = "Eletronicos"},
                new Categoria{id = 2, Status = true, Nome = "Alimentos"},
                new Categoria{id = 3, Status = true, Nome = "Vestuario"},
            };

            //Criando Consulta LINQ
            //01 - Filtrar produtos por nome
            //var resultado = from produto in listaProdutos
            //                where produto.Nome.ToLower() == "ArRoz".ToLower()
            //                select produto;

            //02 - Filtrar produtos pela primeira letra do nome
            //var resultado = from produto in listaProdutos
            //                where produto.Nome.ToLower().Substring(0,1) == "ArRoz".ToLower()
            //                select produto;


            //03 - Filtrar produtos pela primeira letra do nome e status ativo
            //var resultado = from produto in listaProdutos
            //                where produto.Nome.ToLower().Substring(0, 1) == "ArRoz".ToLower() && produto.Status == true
            //                select produto;

            //04 - Ordenar os produtos por ID.
            var resultado = from produto in listaProdutos
                            where produto.Id > 1 && produto.Id < 6
                            orderby produto.Id descending
                            select produto;

            //Executar a Consulta
            foreach (var result in resultado) 
            {
                Console.WriteLine($"{result.Id} | {result.Nome} | {result.Valor} | {result.CategoriaId} | ");
            }
        }
    }


    class Produto 
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public bool Status { get; set; }    
        public decimal Valor { get; set; }  
        public int CategoriaId { get; set; }

    }

    class Categoria {

        public int id  { get; set; }    
        public string Nome { get; set; }
        public bool Status { get; set; }

    }

}