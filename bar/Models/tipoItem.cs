namespace bar.Models
{
    public class tipoItem
    {

        public int id { get; set; }
        public int tipo { get; set; }

        public string nome { get; set; }

        public double preco { get; set; }

        public tipoItem(int n)
        {

            switch (n)
            {
                case 1:
                    nome = "Cerveja";
                    preco = 5;

                    break;
                case 2:
                    nome = "Conhaque";
                    preco = 20;


                    break;
                case 3:
                    nome = "Suco";
                    preco = 50;


                    break;
                case 4:
                    nome = "Agua";
                    preco = 70;

                    break;

                default: 
                    nome = "não encontrado";
                    break;
            }
        }
    }
}
