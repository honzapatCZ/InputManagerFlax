// Copyright (C) 2021 Pavel Patrovský. Do not redistribute!

using System;
using System.Collections.Generic;
using FlaxEngine;

namespace InputManagerFlax
{
    public abstract class InputAction
    {

    }
    public abstract class InputAction<T> : InputAction
    {
        public InputActuator<T>[] actuators;

        public abstract T GetValue(InputDevice[] devices);
    }

    public class FloatInputAction : InputAction<float>
    {
        public override float GetValue(InputDevice[] devices)
        {
            float value = 0;
            foreach (InputActuator<float> ac in actuators)
            {
                value += ac.GetValue();
            }
            return value;
        }
    }
    public class BoolInputAction : InputAction<bool>
    {
        public override bool GetValue(InputDevice[] devices)
        {
            foreach (InputActuator<bool> ac in actuators)
            {
                if (ac.GetValue())
                    return true;
            }
            return false;
        }
    }
    public class Vector2InputAction : InputAction<Vector2>
    {
        public override Vector2 GetValue(InputDevice[] devices)
        {
            Vector2 value = Vector2.Zero;
            foreach (InputActuator<Vector2> ac in actuators)
            {
                value += ac.GetValue();
            }
            return value;
        }
    }
}
