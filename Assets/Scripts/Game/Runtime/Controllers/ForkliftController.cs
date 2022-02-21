using UnityEngine;

namespace Game.Runtime
{
    public class ForkliftController : MonoBehaviour
    {
        [SerializeField] float speed = 1;
        [SerializeField] float liftPower = 1;
        [SerializeField] float steeringSpeed = 1;

        [SerializeField] ArticulationDriveMotor liftMotor;
        [SerializeField] ArticulationDriveMotor[] steeringMotors;
        
        IMotor[] wheelMotors;
        ForkliftInput forklitInput;

        float liftInput;
        Vector2 movementInput;
 
        void Awake()
        {
            forklitInput = new ForkliftInput();
            wheelMotors = GetComponentsInChildren<TorqueMotor>();
        }

        void OnEnable()
        {
            forklitInput.Enable();
        }

        void OnDisable()
        {
            forklitInput.Disable();
        }

        void Update()
        {
            liftInput = forklitInput.Movement.Lift.ReadValue<float>();
            movementInput = forklitInput.Movement.Driving.ReadValue<Vector2>();
        }

        void FixedUpdate()
        {
            var deltaTime = Time.fixedDeltaTime;
            UpdateLifting(deltaTime);
            UpdateDriving(deltaTime);
            UpdateSteering(deltaTime);
        }

        void UpdateLifting(float deltaTime)
        {
            liftMotor.Move(liftInput * liftPower * deltaTime);
        }

        void UpdateDriving(float deltaTime)
        {
            for (int i = 0; i < wheelMotors.Length; i++)
            {
                wheelMotors[i].Move(movementInput.y * speed * deltaTime);
            }
        }

        void UpdateSteering(float deltaTime)
        {
            for (int i = 0; i < steeringMotors.Length; i++)
            {
                steeringMotors[i].Move(movementInput.x * steeringSpeed * deltaTime);
            }
        }
    }
}