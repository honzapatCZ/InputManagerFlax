// Copyright (C) 2021 Pavel Patrovský. Do not redistribute!

using System;
using System.Collections.Generic;
using FlaxEngine;

namespace InputManagerFlax
{
    /// <summary>
    /// InputManager Script.
    /// </summary>
    public class InputManager : Script
    {
        public static object GetAction(string name)
        {
            return GetAction(name, null);
        }
        public static object GetAction(string name, InputMap map)
        {
            return null;
        }
    }
}
