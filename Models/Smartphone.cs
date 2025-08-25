namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        //implementado
        protected string Modelo { get; set; }

        protected string Imei { get; set; }

        protected int Memoria{ get; set; }

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {

            // TODO: Passar os parâmetros do construtor para as propriedades
            //implementado
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}