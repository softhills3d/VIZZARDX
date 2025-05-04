using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PluginConnector;

namespace MyPlugin
{
    public partial class PluginUserControl : UserControl, PluginConnector.IEntryConnector
    {
        private PluginConnector.IPluginService pluginHost;
        private VIZCore3DX.Core vizcore3dx;

        public PluginUserControl()
        {
            InitializeComponent();
        }

        public PluginUserControl(IPluginService host): this()
        {
            pluginHost = host;

            pluginHost.OnInitializedAppEvent += PluginHost_OnInitializedAppEvent;
            pluginHost.OnModelOpenedEvent += PluginHost_OnModelOpenedEvent;
        }

        private void PluginHost_OnInitializedAppEvent(object sender, EventArgs e)
        {
            
        }

        private void PluginHost_OnModelOpenedEvent(object sender, EventArgs e)
        {
            vizcore3dx = (VIZCore3DX.Core)pluginHost.GetVIZCore3DX();
        }
    }
}
