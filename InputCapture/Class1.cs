using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace InputCapture
{
    public class LockoutKeyboardCapture : IKeyboardCapture
    {
        public event EventHandler<KeyboardNotificationEventArgs> KeyboardNotification;
        //private bool _keySent = false;
        private bool _isLocked = false;
        private TimeSpan timeout = new TimeSpan(0, 0, 0, 0, 1000);
        private Stopwatch stopwatch = new Stopwatch();

        private Key _resetKey = Key.Space;

        public LockoutKeyboardCapture() : this (Key.Space)
        { }

        public LockoutKeyboardCapture(Key resetKey)
        {
            _resetKey = resetKey;
        }

        private Dictionary<Key, Timer> _timeouts = new Dictionary<Key, Timer>();

        public void PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (_isLocked && e.Key != _resetKey)
            {
                e.Handled = true;
            }
        }

        public void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == _resetKey)
            {
                _isLocked = true;
            }
            else
            {
                OnKeyboardNotification(e.Key, stopwatch.Elapsed);
            }                                  
        }

        public void KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == _resetKey)
            {
                Reset();
                _isLocked = false;
            }
        }

        public void PreviewKeyUp(object sender, KeyEventArgs e)
        {

        }

        public void Reset()
        {
//            _keySent = false;
            stopwatch.Restart();
        }

        private void SendToTimeout(Key key)
        {
            
        } 

        private void OnKeyboardNotification(Key key, TimeSpan timespan)
        {
            _isLocked = true;
            KeyboardNotification?.Invoke(this, new KeyboardNotificationEventArgs() { Key = key, Time = timespan });
        }

        public void RegisterWindow(UIElement window)
        {            
            window.KeyDown += KeyDown;
            window.PreviewKeyDown += PreviewKeyDown;
            window.PreviewKeyUp += PreviewKeyUp;
            window.KeyUp += KeyUp;
        }
    }
}
