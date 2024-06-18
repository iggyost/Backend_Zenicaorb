using System;
using System.Collections.Generic;

namespace Backend_Zenicaorb.ApplicationData;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Wishes { get; set; }

    public int StatusId { get; set; }

    public int RoomId { get; set; }

    public int UserId { get; set; }

    public int? PetWeight { get; set; }

    public int? PetHeight { get; set; }

    public bool IsVideoSurveillance { get; set; }

    public bool IsPhotoReports { get; set; }

    public decimal TotalCost { get; set; }

    public virtual Room Room { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
