// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace HardwareIntrinsics.RayTracer
{
    internal struct Vector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vector(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}