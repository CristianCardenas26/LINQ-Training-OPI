using LinqTraining.Data;
using LinqTraining.Models;

List <Product> products = SampleData.GetProducts(); 
List <Book> books = SampleData.GetBooks();
List<Order> orders = SampleData.GetOrders();
List<Employee> employees = SampleData.GetEmployees();


var LastMontOrdersByStatus = orders
     .Where(o => o.Date >= DateTime.Today.AddDays(-30))
     .OrderBy(o => o.Status); 

     foreach (var pedido in LastMontOrdersByStatus)
 {

     Console.WriteLine($"Estado: {pedido.Status} | Cliente: {pedido.CustomerName}");
 }

 var Top5MostSellerBooks = books
 .OrderByDescending(b => b.UnitsSold)
 .Take(5);

 foreach (var book in Top5MostSellerBooks)
 {
     Console.WriteLine($"Titulo: {book.Title}, Unidades vendidas: {book.UnitsSold}");
 }

 string busqueda = "poor";
 var FindBookByTitle = books
 .Where (b => b.Title.Contains(busqueda, StringComparison.OrdinalIgnoreCase));

 foreach (var book in FindBookByTitle)
 {
     Console.WriteLine($"Titulo: {book.Title}, Autor: {book.Author}");
 }

 var Top3MostBuyerClients = orders
 .OrderByDescending (o =>o.Amount)
 .Take(3);

 foreach ( var order in Top3MostBuyerClients)
 {
     Console.WriteLine($"Cliente: {order.CustomerName}, Monto: {order.Amount} ");
 }

 var PendingClients = orders
 .Where (o => o.Status == "Pending");
 foreach ( var order in PendingClients)
 {
     Console.WriteLine($"Cliente: {order.CustomerName}, Estado: {order.Status}, Por un monto de: {order.Amount}");
 }


