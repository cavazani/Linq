namespace Linq {
    class Program 
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
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