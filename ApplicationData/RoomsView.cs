using System;
using System.Collections.Generic;

namespace Backend_Zenicaorb.ApplicationData;

public partial class RoomsView
{
    public int RoomId { get; set; }

    public string Name { get; set; } = null!;

    public int HotelId { get; set; }

    public string Address { get; set; } = null!;

    public string? Metro { get; set; }

    public string? WorkTime { get; set; }

    public string? Email { get; set; }

    public string? HotelPhone { get; set; }

    public int ClassId { get; set; }

    public string Class { get; set; } = null!;

    public int CategoryId { get; set; }

    public string Category { get; set; } = null!;

    public string CoverImage { get; set; } = null!;

    public int? AreaMeter { get; set; }

    public int PlacesCount { get; set; }

    public decimal Cost { get; set; }
}
