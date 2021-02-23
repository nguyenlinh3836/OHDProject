﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHDProject.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }       
        public string LastName { get; set; }    
        public string Password { get; set; }
        public string Gender { get; set; }   
        public string Address { get; set; }     
        public string Contact { get; set; }
        public int RoleID { get; set; }

        public Role Role { get; set; }

    }
}
