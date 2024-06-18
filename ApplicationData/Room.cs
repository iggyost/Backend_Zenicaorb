using System;
using System.Collections.Generic;

namespace Backend_Zenicaorb.ApplicationData;

public partial class Room
{
    public int RoomId { get; set; }

    public string Name { get; set; } = null!;

    public int HotelId { get; set; }

    public int ClassId { get; set; }

    public int CategoryId { get; set; }

    public int? AreaMeter { get; set; }

    public int PlacesCount { get; set; }

    public decimal Cost { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Class Class { get; set; } = null!;

    public virtual Hotel Hotel { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<RoomsImage> RoomsImages { get; set; } = new List<RoomsImage>();
}
