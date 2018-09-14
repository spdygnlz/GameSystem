using System.Windows.Input;
using System;
using System.Windows;

namespace InputCapture
{
    public interface IKeyboardCapture
    {
        event EventHandler<KeyboardNotificationEventArgs> KeyboardNotification;

        void PreviewKeyDown(object sender, KeyEventArgs e);
        void KeyDown(object sender, KeyEventArgs e);
        void KeyUp(object sender, KeyEventArgs e);
        void PreviewKeyUp(object sender, KeyEventArgs e);
        void Reset();
        void RegisterWindow(UIElement window);
    }
}