using Pilas_colas_y_colas_dobles;
using Pilas_colas_y_colas_dobles.Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        LinkedStack<Ventana> ventana = new LinkedStack<Ventana>();

        ventana.Push(new Ventana() { NombreVentana = "Ventana 1 roles", Usuario = "Usuario Dallin" });
        ventana.Push(new Ventana() { NombreVentana = "Ventana 2 usuarios", Usuario = "Usuario Javier" });
        ventana.Push(new Ventana() { NombreVentana = "Ventana 3 Perfil", Usuario = "Usuario Jazz" });
        ventana.Push(new Ventana() { NombreVentana = "Ventana 4 Ayuda", Usuario = "Usuario Daniel" });
        ventana.Push(new Ventana() { NombreVentana = "Ventana 5 Reportes", Usuario = "Usuario Kevin" });
        ventana.Push(new Ventana() { NombreVentana = "Ventana 6 Configuracion ", Usuario = "Usuario Betza" });


        Console.WriteLine($"Ventana Activa:-  {ventana.Peek()}");
        Console.WriteLine($"Cerrando:-  {ventana.Pop()}\n");
        Console.WriteLine($"Ventana Activa:-  {ventana.Peek()}");
        Console.WriteLine($"Cerrando:-  {ventana.Pop()}\n");
        Console.WriteLine($"Ventana Activa:-  {ventana.Peek()}");
        Console.WriteLine($"Cerrando:-  {ventana.Pop()}\n");
        Console.WriteLine($"Ventana Activa:-  {ventana.Peek()}");


        Console.WriteLine($"\nVentanas activas en el historial: {ventana.Count()}");



    }
}