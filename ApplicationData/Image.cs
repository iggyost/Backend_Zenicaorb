using System;
using System.Collections.Generic;

namespace Backend_Zenicaorb.ApplicationData;

public partial class Image
{
    public int ImageId { get; set; }

    public string Image1 { get; set; } = null!;

    public virtual ICollection<RoomsImage> RoomsImages { get; set; } = new List<RoomsImage>();
}
