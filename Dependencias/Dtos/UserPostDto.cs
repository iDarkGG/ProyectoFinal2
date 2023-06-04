﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dependencias.Dtos;

public class UserPostDto
{

    [Required]
    public string UserName { get; set; }
    public string Email { get; set; }

    public string Password { get; set; }
}
