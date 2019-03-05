using Prism.Mef;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Modularity;
using System.ComponentModel.Composition;
using Prism.Logging;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;

namespace GameSystem
{
    public class MyBootstrapper : MefBootstrapper
    {
        protected override void ConfigureAggregateCatalog()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            AggregateCatalog.Catalogs.Add(new DirectoryCatalog(path, "*.dll"));
            //AggregateCatalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(path, "Modules"), "*.dll"));
            AggregateCatalog.Catalogs.Add(new DirectoryCatalog(path, "*.exe"));
            base.ConfigureAggregateCatalog();            
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            
            // TODO: Would like to do this in its own folder.
            //var modulePath = Path.Combine(path, "Modules");

            return new DirectoryModuleCatalog() { ModulePath = path };
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.ComposeExportedValue(Container);
        //    Container.ComposeExportedValue<ILoggerFacade>(this.Logger);
        //    Container.ComposeExportedValue<IModuleCatalog>(this.ModuleCatalog);
        //    Container.ComposeExportedValue<IServiceLocator>(new MefServiceLocatorAdapter(this.Container));
        //    Container.ComposeExportedValue<AggregateCatalog>(this.AggregateCatalog);
        }

        protected override DependencyObject CreateShell()
        {        
            return Container.GetExportedValue<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Shell)Shell;
            ((Shell)Shell).DataContext = ServiceLocator.Current.GetInstance<ShellViewModel>();
            Application.Current.MainWindow.Show();
        }
    }
}
