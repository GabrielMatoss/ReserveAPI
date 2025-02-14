namespace Reservation.Domain.Entities;

public class Table : EntityBase
{
    public int TableNumber { get; set; }
    public int Capacity { get; set; }
    public bool IsReserved { get; set; }
    public int? ReservationId { get; set; }
    public IEnumerable<Reserve> Reserves { get; set; } 

    public Table(int tableNumber, int capacity = 2, bool isReserved = false)
    {
        TableNumber = tableNumber;
        Capacity = capacity;
        IsReserved = isReserved;
        Reserves = new List<Reserve>();
    }
    public Table(int id, int tableNumber, int capacity = 2, bool isReserved = false)
    : this(tableNumber, capacity, isReserved)
    {
        Id = id;
    }
}