﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpresaAPI.Models
{
    public class LoginRequest
    {
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }
}