using Codemunkie.DevTools.Properties;
using NHotkey.WindowsForms;

namespace Codemunkie.DevTools
{
    public class DevToolsApplicationContext : ApplicationContext
    {
        private static readonly IEnumerable<ToolBindingCategory> toolBindingCategories =
        [
            new ToolBindingCategory("Clipboard",
            [
                new ToolBinding("Clipboard to CSL", Keys.Control | Keys.Alt | Keys.F10, ClipboardToCsl.Handle)
            ])
        ];
        
        private NotifyIcon trayIcon;

        public DevToolsApplicationContext()
        {
            Application.ApplicationExit += Application_ApplicationExit;

            trayIcon = new NotifyIcon
            {
                Icon = Resources.AppIcon,
                Visible = true,
                ContextMenuStrip = BuildMenu(),
                Text = "Codemunkie's Dev Tools"
            };

            foreach (var b in toolBindingCategories.SelectMany(c => c.ToolBindings))
            {
                HotkeyManager.Current.AddOrReplace(b.Name, b.Keys, (sender, e) => b.Handler());
            }
        }
        

        private ContextMenuStrip BuildMenu()
        {
            var menu = new ContextMenuStrip();

            foreach (var category in toolBindingCategories)
            {
                foreach (var b in category.ToolBindings)
                {
                    menu.Items.Add(new ToolStripMenuItem(b.Name, null, (sender, e) => b.Handler(), b.Keys));
                }
                menu.Items.Add(new ToolStripSeparator());
            }

            menu.Items.Add(new ToolStripMenuItem("Exit", null, Exit));

            return menu;
        }

        private void Exit(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Application_ApplicationExit(object? sender, EventArgs e)
        {
            foreach (var b in toolBindingCategories.SelectMany(c => c.ToolBindings))
            {
                HotkeyManager.Current.Remove(b.Name);
            }

            trayIcon.Visible = false;
        }
    }
}