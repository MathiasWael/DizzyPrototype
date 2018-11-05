﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Models
{
    public enum MenuItemType
    {
        Browse,
        StepCounter,
        DizzinessRegister
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
