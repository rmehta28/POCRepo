﻿using BeanStalkPOC.Core.BaseEntity;
using System;

namespace BeanStalkPOC.Core.Entities
{
    public class User : BaseEntityLong
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
