using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_OgrenmeApp.Migrations
{
    [Migration(1)]
    public class _001_Users_and_Roles : Migration
    {

        public override void Down()
        {
            Delete.Table("Ogretmen_Ders");
            Delete.Table("Dersler");
            Delete.Table("Ogretmenler");
        }
        public override void Up()
        {
            Create.Table("Ogretmenler").WithColumn("Id").AsInt32().Identity().PrimaryKey()
                                        .WithColumn("Ogretmen_Adı").AsString(128)
                                        .WithColumn("Ogretmen_Soyadı").AsString(128)
                                        .WithColumn("Verdigi_Ders").AsString(128);
            Create.Table("Dersler").WithColumn("Id").AsInt32().Identity().PrimaryKey()
                                       .WithColumn("Ders_Adı").AsString(128)
                                       .WithColumn("Ders_Konu").AsString(128)
                                       .WithColumn("Link").AsString()
                                       .WithColumn("Pdf").AsString(128);



            Create.Table("Ogretmen_Ders").WithColumn("Ogr_Id").AsInt32().ForeignKey("Ogretmenler", "Id").OnDelete(System.Data.Rule.Cascade)
                                           .WithColumn("Ders_Id").AsInt32().ForeignKey("Dersler", "Id").OnDelete(System.Data.Rule.Cascade);


        }
    }
}