namespace DesafioPOO.Models
{
	// Classe implementada
	public class Iphone : Smartphone
	{
		// Método Implementado
		public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
		{
		}

		public override void InstalarAplicativo(string nomeApp)
		{
			Console.WriteLine($"Instalado o aplicativo \"{nomeApp}\" no IPhone");
		}
	}
}