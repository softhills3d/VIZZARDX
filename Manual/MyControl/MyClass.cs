using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PluginConnector;

namespace MyControl
{
    public class MyClass : PluginConnector.IEntryConnector
    {
        private PluginConnector.IPluginService pluginHost;

        public MyClass()
        {
        }

        public MyClass(IPluginService host) : this()
        {
            pluginHost = host;

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

            VIZCore3DX.Core vizcore3dx = (VIZCore3DX.Core)pluginHost.GetVIZCore3DX();
        }
    }
}
