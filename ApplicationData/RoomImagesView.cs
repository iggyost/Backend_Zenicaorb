using System;
using System.Collections.Generic;

namespace Backend_Zenicaorb.ApplicationData;

public partial class RoomImagesView
{
    public int RoomId { get; set; }

    public int ImageId { get; set; }

    public string Image { get; set; } = null!;
}
