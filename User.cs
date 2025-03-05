using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class User
{
    public int IdUsers { get; set; }

    public string UserName { get; set; } = null!;

    public string Userspaasword { get; set; } = null!;
}
