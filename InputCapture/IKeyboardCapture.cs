using System.Windows.Input;
using System;
using System.Windows;

namespace InputCapture
{
    public interface IKeyboardCapture
    {
        event EventHandler<KeyboardNotificationEventArgs> KeyboardNotification;
        event EventHandler<EventArgs> KeyboardReset;

        void PreviewKeyDown(object sender, KeyEventArgs e);
        void KeyDown(object sender, KeyEventArgs e);
        void KeyUp(object sender, KeyEventArgs e);
        void PreviewKeyUp(object sender, KeyEventArgs e);
        void Reset();
        void RegisterWindow(UIElement window);
        int LookupIntKey(Key key);
        char LookupCharKey(Key key);
        void SuspendNotifications(bool value);
    }
}