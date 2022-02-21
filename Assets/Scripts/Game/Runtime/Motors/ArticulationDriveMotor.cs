using Game.Runtime.Extensions;
using UnityEngine;

namespace Game.Runtime
{
    [RequireComponent(typeof(ArticulationBody))]
    public class ArticulationDriveMotor : MonoBehaviour, IMotor
    {
        [SerializeField] Axis axis;
        
        ArticulationBody articulationBody;
        ArticulationDrive drive;

        public Axis Axis => axis;

        void Awake()
        {
            articulationBody = GetComponent<ArticulationBody>();
            drive = articulationBody.GetDriveForAxis(axis);
        }

        public void Move(float delta)
        {
            drive.target = Mathf.Clamp(drive.target + delta, drive.lowerLimit, drive.upperLimit);
            articulationBody.SetDriveForAxis(drive, axis);
        }
        
    }
}