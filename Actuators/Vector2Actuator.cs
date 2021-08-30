// Copyright (C) 2021 Pavel Patrovský. Do not redistribute!

using System;
using System.Collections.Generic;
using FlaxEngine;

namespace InputManagerFlax
{
    public class Vector2Actuator : InputActuatorWithPath<Vector2>
    {
        public override Vector2 GetValue()
        {
            return Vector2.Zero;
        }
    }
}
