using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripProj.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public enum Role { Admin, User, Guest }
    }
}