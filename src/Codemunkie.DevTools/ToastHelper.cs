using Microsoft.Toolkit.Uwp.Notifications;

namespace Codemunkie.DevTools
{
    public static class ToastHelper
    {
        public static void Show(string message)
        {
            new ToastContentBuilder()
                .AddText(message)
                .Show();
        }
    }
}
