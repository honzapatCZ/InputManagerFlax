// Copyright (C) 2021 Pavel Patrovský. Do not redistribute!

using System;
using System.Collections.Generic;
using FlaxEngine;

namespace InputManagerFlax
{
    /// <summary>
    /// InputActuator Script.
    /// </summary>
    public abstract class InputActuator<T>
    {
        public InputActuator(){
                    
        }

        public abstract T GetValue();
    }
    public abstract class InputActuatorWithPath<T> : InputActuator<T>
    {
        public string Path { get; set; }
    }
}
