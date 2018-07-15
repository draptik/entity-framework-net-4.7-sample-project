using System;
using System.Configuration;
using System.IO;

namespace DemoApp.DbLocator
{
    public static class LocateDevDb
    {
        /// <summary>
        ///     <para>Use this method if the database destination directory should be located in a different assembly.</para>
        ///     <para>Setting the connection string in App.config to a relative path does not work from within unit tests.</para>
        ///     <para>Example App.config (this does not work!):</para>
        ///     <connectionStrings>
        ///         <add name="FooDbContext"
        ///             connectionString="Data Source=(LocalDb)\mssqllocaldb;AttachDbFilename=..\Foo.Web\|DataDirectory|\SomeDb.mdf;Integrated Security=True"
        ///             providerName="System.Data.SqlClient" />
        ///     </connectionStrings>
        ///     <para>Add a key 'dataDir' to appSettings in App.config with the relative path to the destination directory.</para>
        ///     <para>Example App.config:</para>
        ///     <appSettings>
        ///         <add key="dataDir" value="..\..\..\Foo.Web\App_Data" />
        ///     </appSettings>
        ///     <connectionStrings>
        ///         <add name="FooDbContext"
        ///             connectionString="Data Source=(LocalDb)\mssqllocaldb;AttachDbFilename=|DataDirectory|\SomeDb.mdf;Integrated Security=True"
        ///             providerName="System.Data.SqlClient" />
        ///     </connectionStrings>
        /// </summary>
        public static void SetDataDirectory()
        {
            var appSetting = ConfigurationManager.AppSettings["dataDir"];
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var path = Path.Combine(baseDir, appSetting);
            var fullPath = Path.GetFullPath(path);
            AppDomain.CurrentDomain.SetData("DataDirectory", fullPath);
        }
    }
}