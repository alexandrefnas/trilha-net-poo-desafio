namespace DesafioPOO.Models
{
	// Classe Implementada
	public class Nokia : Smartphone
	{
		// Método Implementado
		public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
		{			
		}
		
		public override void InstalarAplicativo(string nomeApp)
		{
			Console.WriteLine($"Instalado o aplicativo \"{nomeApp}\" no Nokia");
		}
	}
}