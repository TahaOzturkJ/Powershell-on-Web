using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WEBUI.VMClasses
{
    public class IndexVM
    {
        public List<User> Users { get; set; }
        public User User { get; set; }
    }
}