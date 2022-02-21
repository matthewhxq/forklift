using Game.Runtime.Extensions;
using UnityEngine;

namespace Game.Runtime
{
    public class TorqueMotor : MonoBehaviour, IMotor
    {
        [SerializeField] Axis axis;
        
        ArticulationBody articulationBody;
        
        public Axis Axis => axis;

        void Awake()
        {
            articulationBody = GetComponent<ArticulationBody>();
        }

        public void Move(float delta)
        {
            articulationBody.AddRelativeTorque(delta * axis.AsVector());
        }

    }
}