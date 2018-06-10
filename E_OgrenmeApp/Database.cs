using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using E_OgrenmeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_OgrenmeApp
{
    public static class Database
    {
        private static ISessionFactory _sessionFactory;
        private const string SessionKey = "eogrenme.Database.SessionKey";
        public static void Configure()//APP Level - Only Once //bu sadece bir kez app startda çağırılıyor.
        {
            var config = new Configuration();
            config.Configure();
            //select  connection string

            var mapper = new ModelMapper();
            mapper.AddMapping<DerslerMap>();
            mapper.AddMapping<OgretmenlerMap>();
            config.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());
            //add mapping
            _sessionFactory = config.BuildSessionFactory();
            //create session factory
        }
        public static ISession Session
        {
            get
            {
                return (ISession)HttpContext.Current.Items[SessionKey];
            }
        }
        public static void OpenSession()//Request Level - per request
        {
            HttpContext.Current.Items[SessionKey] = _sessionFactory.OpenSession();
        }
        public static void CloseSession()//Request Level - per request
        {
            var session = HttpContext.Current.Items[SessionKey] as ISession;
            if (session != null)
            {
                session.Close();
            }
            HttpContext.Current.Items.Remove(SessionKey);
        }
    }
}