﻿using System;

namespace Game1
{
    [Serializable]
    public class JeopardyQuestion
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public uint Value { get; set; }
        public bool Used { get; set; }        
    }
}
