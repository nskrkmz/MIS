using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MIS.Entity
{
    class Context:DbContext
    {
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<BorcluMusteri> BorcluMusteris { get; set; }
        public DbSet<Calisan> Calisans { get; set; }
        public DbSet<Depo> Depos { get; set; }
        public DbSet<Fis> Fiss { get; set; }
        public DbSet<Irsaliye> Irsaliyes { get; set; }
        public DbSet<Islem> Islems { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<MusteriBorc> MusteriBorcs { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<TedarikciBorc> TedarikciBorcs { get; set; }




    }
}
