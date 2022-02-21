//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Configs/Forklift Input.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ForkliftInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ForkliftInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Forklift Input"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""c3e34f9f-902c-413b-a087-e17987cea2ca"",
            ""actions"": [
                {
                    ""name"": ""Lift"",
                    ""type"": ""Button"",
                    ""id"": ""d6a545f1-6b2f-4fc9-a3a3-43ae1f533080"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Driving"",
                    ""type"": ""Value"",
                    ""id"": ""775714e7-d1eb-427a-abeb-054fa42d7afb"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Up & Down"",
                    ""id"": ""867dda03-e9e9-42cd-98fb-3d874dc12653"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lift"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4ff3b320-c656-4b8e-8d67-3a0fe6f5bc36"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7803bd16-0e7a-41ca-8861-1e1781a059cf"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""0376adb1-d5d2-4e40-a652-9d40c0b9a765"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Driving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d8efbf9f-31bf-4390-96ef-421d365df52a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Driving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""98b3b0b3-070f-4188-869e-6f9184ea295a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Driving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ef31b3e-2d60-45e1-b36b-aa9d0d66dd60"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Driving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1ac3762a-c4d3-4568-9a51-7947d89c9411"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Driving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Lift = m_Movement.FindAction("Lift", throwIfNotFound: true);
        m_Movement_Driving = m_Movement.FindAction("Driving", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Lift;
    private readonly InputAction m_Movement_Driving;
    public struct MovementActions
    {
        private @ForkliftInput m_Wrapper;
        public MovementActions(@ForkliftInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Lift => m_Wrapper.m_Movement_Lift;
        public InputAction @Driving => m_Wrapper.m_Movement_Driving;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Lift.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLift;
                @Lift.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLift;
                @Lift.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLift;
                @Driving.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnDriving;
                @Driving.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnDriving;
                @Driving.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnDriving;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Lift.started += instance.OnLift;
                @Lift.performed += instance.OnLift;
                @Lift.canceled += instance.OnLift;
                @Driving.started += instance.OnDriving;
                @Driving.performed += instance.OnDriving;
                @Driving.canceled += instance.OnDriving;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnLift(InputAction.CallbackContext context);
        void OnDriving(InputAction.CallbackContext context);
    }
}