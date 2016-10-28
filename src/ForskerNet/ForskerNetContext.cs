using ForskerNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForskerNet
{
    public class ForskerNetContext : DbContext
    {
        public DbSet<Publication> Publications { get; set; }
    }
}
