namespace WebApiClientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required int Age { get; set; }
        public int Phone { get; set; }
        public DateOnly Fecha { get; set; }

    }
}
