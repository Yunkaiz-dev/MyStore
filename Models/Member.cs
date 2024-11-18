using System;
using System.Collections.Generic;

namespace MyStore.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public int UserId { get; set; }

    public string MemberPassword { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public virtual User User { get; set; } = null!;
}
