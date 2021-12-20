using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace XMLSer.Classes
{
    class AppContext:DbContext
    {
        public DbSet<LapTemplates> LapTemplates { get; set; }
        public DbSet<LapPhoto> LapPhoto { get; set; }
        public DbSet<PCTemplates> PCTemplates { get; set; }
        public DbSet<PCPhoto> PCPhoto { get; set; }
        public DbSet<PhoneTemplates> PhoneTemplates { get; set; }
        public DbSet <PhonePhoto> PhonePhotos { get; set; }
        public DbSet<ToolTemplates> ToolTemplates { get; set; }
        public DbSet<ToolPhoto> ToolPhoto { get; set; }
        public DbSet<JewelryTemplates> JewelryTemplates { get; set;}
        public DbSet<JewelryPhoto> JewelryPhoto { get; set; }
        public AppContext() : base("DefaultConnection") { }
    }
}
