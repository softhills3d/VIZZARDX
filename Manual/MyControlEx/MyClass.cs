using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginConnector;

namespace MyControlEx
{
    public class MyClass : PluginConnector.IEntryConnector
    {
        private PluginConnector.IPluginService pluginHost;
        private VIZCore3DX.Core vizcore3dx;

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Docking.DockManager dockManager;

        public MyClass()
        {
        }

        public MyClass(IPluginService host) : this()
        {
            pluginHost = host;

            vizcore3dx = (VIZCore3DX.Core)pluginHost.GetVIZCore3DX();

            ribbon = (DevExpress.XtraBars.Ribbon.RibbonControl)pluginHost.GetRibbonControl();
            dockManager = (DevExpress.XtraBars.Docking.DockManager)pluginHost.GetDockManager();

            pluginHost.OnInitializedAppEvent += PluginHost_OnInitializedAppEvent;
            pluginHost.OnModelOpenedEvent += PluginHost_OnModelOpenedEvent;
        }

        private void PluginHost_OnInitializedAppEvent(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Plugin-OnInitializedAppEvent");
        }

        private void PluginHost_OnModelOpenedEvent(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Plugin-OnModelOpenedEvent");
        }
    }
}
