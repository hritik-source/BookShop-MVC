using System;
using System.Collections.Generic;

namespace bookshop.Models;

public partial class ManasFerry
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int RoomsLeft { get; set; }

    public double Charge { get; set; }

    public int Origin { get; set; }

    public int Destination { get; set; }

    public DateTime Departure { get; set; }

    public virtual ManasPort DestinationNavigation { get; set; } = null!;

    public virtual ICollection<ManasTicket> ManasTickets { get; } = new List<ManasTicket>();

    public virtual ManasPort OriginNavigation { get; set; } = null!;
}
