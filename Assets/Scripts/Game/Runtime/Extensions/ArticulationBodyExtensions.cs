using UnityEngine;

namespace Game.Runtime.Extensions
{
    public static class ArticulationBodyExtensions
    {
        public static ArticulationDrive GetDriveForAxis(this ArticulationBody body, Axis targetAxis)
        {
            switch (targetAxis)
            {
                case Axis.X: return body.xDrive;
                case Axis.Y: return body.yDrive;
                case Axis.Z: return body.zDrive;
            }

            return default;
        }
        
        public static void SetDriveForAxis(this ArticulationBody body, ArticulationDrive target, Axis axis)
        {
            switch (axis)
            {
                case Axis.X: body.xDrive = target;
                    break;
                case Axis.Y: body.yDrive = target;
                    break;
                case Axis.Z: body.zDrive = target;
                    break;
            }
        }

        public static Vector3 AsVector(this Axis axis)
        {
            switch (axis)
            {
                case Axis.X: return Vector3.right;
                case Axis.Y: return Vector3.up;
                case Axis.Z: return Vector3.forward;
            }

            return default;
        }
    }
}