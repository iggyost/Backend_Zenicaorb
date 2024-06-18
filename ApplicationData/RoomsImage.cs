using System;
using System.Collections.Generic;

namespace Backend_Zenicaorb.ApplicationData;

public partial class RoomsImage
{
    public int RoomImageId { get; set; }

    public int RoomId { get; set; }

    public int ImageId { get; set; }

    public virtual Image Image { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
