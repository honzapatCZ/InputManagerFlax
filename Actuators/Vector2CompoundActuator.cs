// Copyright (C) 2021 Pavel Patrovský. Do not redistribute!

using System;
using System.Collections.Generic;
using FlaxEngine;

namespace InputManagerFlax
{
    public class Vector2CompoundActuator : InputActuator<Vector2>
    {
        public InputActuator<float> XAxis;
        public InputActuator<float> YAxis;

        public override Vector2 GetValue()
        {
            return new Vector2(XAxis.GetValue(), YAxis.GetValue());
        }
    }
}
