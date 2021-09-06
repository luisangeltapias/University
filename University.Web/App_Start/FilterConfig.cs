using LinqToDB;
using System.Web.Mvc;

namespace University.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
    <connectionStrings>
    <add name = "DefaultConnection" connectionString="Data Source=LATM;Initial Catalog=University;User ID=UserUniversity;Password=123456" ProviderName="System.Data.SqlClient" />
}


