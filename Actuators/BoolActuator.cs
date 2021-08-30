// Copyright (C) 2021 Pavel Patrovský. Do not redistribute!

using System;
using System.Collections.Generic;
using FlaxEngine;

namespace InputManagerFlax
{
    public class BoolActuator : InputActuatorWithPath<bool>
    {
        public override bool GetValue()
        {
            return false;
        }
    }
}
