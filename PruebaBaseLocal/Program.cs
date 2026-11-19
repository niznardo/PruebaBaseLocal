
// See https://aka.ms/new-console-template for more information
using BaseLocal;
using PruebaBaseLocal;

Console.WriteLine("Hello, World!");

//var sistema = new Sistemas();
//var c1 = new Cliente(1, "Juan Perez", "algo@gmail.com");
//var c2 = new Cliente(2, "Maria Lopez", "lmaria@gmail.com");
//sistema.Clientes.Add(c1);
//sistema.Clientes.Add(c2);

//var p1 = new Producto(1, "Producto 1", 10.5m);
//var p2 = new Producto(2, "Producto 2", 20.0m);
//sistema.Productos.Add(p1);
//sistema.Productos.Add(p2);




var sistema = Persistencia.CargarOCrear<Sistemas>();

Console.WriteLine("Clientes:");

var clientesFiltrados = sistema.Clientes.Where(x => x.Name.Contains("Lopez")).ToList();


foreach (var cliente in clientesFiltrados)
{
    Console.WriteLine(cliente.MostrarInformacion());
}

Console.WriteLine("Productos:");
foreach (var producto in sistema.Productos)
{
    Console.WriteLine(producto.MostrarInformacion());
}

var c1 = new Cliente(3, "Carlos Sanchez", "csanchez@gmail.com");
sistema.Clientes.Add(c1);

Persistencia.Guardar(sistema);

