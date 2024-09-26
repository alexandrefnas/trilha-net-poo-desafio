namespace DesafioPOO.Models
{
	public abstract class Smartphone
	{
		public string Numero { get; set; }

		// Métodos implementados
		protected string Modelo { get; set; }
		protected string Imei { get; set; }
		protected int Memoria { get; set; }

		public Smartphone(string numero, string modelo, string imei, int memoria)
		{
			Numero = numero;
			//Métodos Implementados
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

		public void DadosSmartphone()
		{
			Console.WriteLine($"Número: {Numero}, Modelo: {Modelo}, IMEI: {Imei}, Memória: {Memoria}");
		}
	}
}