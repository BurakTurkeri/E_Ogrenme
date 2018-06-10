using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_OgrenmeApp.Models
{
    public class Dersler
    {
        public virtual int Id { get; set; }
        public virtual string Ders_Adı { get; set; }
        public virtual string Ders_Konu { get; set; }

        public virtual string Link { get; set; }
        public virtual string Pdf { get; set; }
    }

    public class DerslerMap : ClassMapping<Dersler>
    {
        public DerslerMap()

        {
            Table("Dersler");
            Id(x => x.Id, x => x.Generator(Generators.Identity));
            Property(x => x.Ders_Adı, x => x.NotNullable(true));
            Property(x => x.Ders_Konu, x => x.NotNullable(true));

            Property(x => x.Link, x => x.NotNullable(true));
            Property(x => x.Pdf, x => x.NotNullable(true));

        }

    }

}