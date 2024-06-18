using System;
using System.Collections.Generic;

namespace Backend_Zenicaorb.ApplicationData;

public partial class Hotel
{
    public int HotelId { get; set; }

    public string Address { get; set; } = null!;

    public string? Metro { get; set; }

    public string? WorkTime { get; set; }

    public string? Email { get; set; }

    public string? HotelPhone { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
