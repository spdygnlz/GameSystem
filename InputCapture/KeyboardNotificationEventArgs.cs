﻿using System;
using System.Windows.Input;

namespace InputCapture
{
    public class KeyboardNotificationEventArgs : EventArgs
    {
        public TimeSpan Time { get; set; }
        public Key Key { get; set; }
    }
}