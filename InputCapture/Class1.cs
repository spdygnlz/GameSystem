using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace InputCapture
{
    public class LockoutKeyboardCapture : IKeyboardCapture
    {
        public event EventHandler<KeyboardNotificationEventArgs> KeyboardNotification;
        public event EventHandler<EventArgs> KeyboardReset;

        //private bool _keySent = false;
        private bool _isLocked = false;
        private TimeSpan timeout = new TimeSpan(0, 0, 0, 0, 1000);
        private Stopwatch stopwatch = new Stopwatch();
        private UIElement owner = null;

        public static Dictionary<Key, int> IntKeyLookup = new Dictionary<Key, int>()
        {
            { Key.D0, 0 }, { Key.D1, 1}, { Key.D2, 2}, {Key.D3, 3}, {Key.D4, 4 }, {Key.D5, 5}, {Key.D6, 6}, {Key.D7, 7}, {Key.D8, 8}, {Key.D9, 9}
        };

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
            if (!IsParentOf(sender as UIElement, owner)) return;

            if (_isLocked && e.Key != _resetKey)
            {
                e.Handled = true;
            }
        }

        public void KeyDown(object sender, KeyEventArgs e)
        {
            if (!IsParentOf(sender as UIElement, owner)) return;

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
            if (!IsParentOf(sender as UIElement, owner)) return;

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

            this.KeyboardReset?.Invoke(this, new EventArgs());
        }

        private void SendToTimeout(Key key)
        {
            
        } 

        private void OnKeyboardNotification(Key key, TimeSpan timespan)
        {
            _isLocked = true;
            KeyboardNotification?.Invoke(this, new KeyboardNotificationEventArgs() { Key = key, Time = timespan, Owner = owner});
        }

        public void RegisterWindow(UIElement window)
        {
            owner = window;
            window.KeyDown += KeyDown;
            window.PreviewKeyDown += PreviewKeyDown;
            window.PreviewKeyUp += PreviewKeyUp;
            window.KeyUp += KeyUp;
        }



        public bool IsParentOf(UIElement child, UIElement parent)
        {
            if (child == parent) return true;

            var foundParent = FindParent<Window>(child);
            return (foundParent != null && foundParent == parent);
        }

        private static T FindParent<T>(DependencyObject child) where T : DependencyObject
        {
            //get parent item
            DependencyObject parentObject = VisualTreeHelper.GetParent(child);

            //we've reached the end of the tree
            if (parentObject == null) return null;

            //check if the parent matches the type we're looking for
            T parent = parentObject as T;
            if (parent != null)
                return parent;
            else
                return FindParent<T>(parentObject);
        }

        public int LookupIntKey(Key key)
        {            
            if (IntKeyLookup.TryGetValue(key, out int outputValue))
            {
                return outputValue;
            }

            return -1;
        }

        public char LookupCharKey(Key key)
        {
            throw new NotImplementedException();
        }
    }
}
