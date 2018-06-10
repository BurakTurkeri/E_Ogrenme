using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_OgrenmeApp.Models
{
    public class Ogretmenler
    {
        public virtual int Id { get; set; }
        public virtual string Ogretmen_Adı { get; set; }
        public virtual string Ogretmen_Soyadı { get; set; }
        public virtual string Verdigi_Ders { get; set; }

    }
    public class OgretmenlerMap : ClassMapping<Ogretmenler>
    {
        public OgretmenlerMap()
        {
            Table("Ogretmenler");

            Id(x => x.Id, x => x.Generator(Generators.Identity));
            Property(x => x.Ogretmen_Adı, x => x.NotNullable(true));
            Property(x => x.Ogretmen_Soyadı, x => x.NotNullable(true));
            Property(x => x.Verdigi_Ders, x => x.NotNullable(true));

        }
    }
}