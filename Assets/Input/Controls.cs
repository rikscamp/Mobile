// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""1c9194d4-92ac-402e-b1bc-e70c3e21cf02"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""cf6d8a33-a813-49d3-a444-fafa98c1474c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bfec5c34-fefc-4721-924d-5f9069122ff4"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""40a9946e-2335-421c-8f80-42a374c18bee"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""52c7ed5a-280b-4373-b2a1-6e17a1843e30"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5cf8cb1d-a082-4deb-b56e-ddc6a9abc7ce"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""49d35338-b88d-4bff-a06e-26a26d932d86"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""707f113d-e6ee-483d-ae0b-347a3ae3995e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Punch"",
            ""id"": ""1aefa47d-f30c-4772-90c4-084d872892db"",
            ""actions"": [
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""5e48e7c3-76b1-4aa6-9ebe-dbfd7a7f6e90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""856d1c5e-c01a-4589-9114-04c2c86094af"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Wipes"",
            ""id"": ""c3ac57b6-edb5-4320-95e2-ac75d1683b7a"",
            ""actions"": [
                {
                    ""name"": ""smear"",
                    ""type"": ""Value"",
                    ""id"": ""70731935-bf54-48cd-8e71-259d12b725d8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""smearL"",
                    ""type"": ""Value"",
                    ""id"": ""31cd8539-9d0a-43f9-8655-23d544d869e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e93553bc-ab09-4ac8-92ea-ae33725291d5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""smear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91136185-285d-4971-babc-737fd33439b2"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""smearL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        // Punch
        m_Punch = asset.FindActionMap("Punch", throwIfNotFound: true);
        m_Punch_Tap = m_Punch.FindAction("Tap", throwIfNotFound: true);
        // Wipes
        m_Wipes = asset.FindActionMap("Wipes", throwIfNotFound: true);
        m_Wipes_smear = m_Wipes.FindAction("smear", throwIfNotFound: true);
        m_Wipes_smearL = m_Wipes.FindAction("smearL", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    public struct GameplayActions
    {
        private @Controls m_Wrapper;
        public GameplayActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Punch
    private readonly InputActionMap m_Punch;
    private IPunchActions m_PunchActionsCallbackInterface;
    private readonly InputAction m_Punch_Tap;
    public struct PunchActions
    {
        private @Controls m_Wrapper;
        public PunchActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tap => m_Wrapper.m_Punch_Tap;
        public InputActionMap Get() { return m_Wrapper.m_Punch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PunchActions set) { return set.Get(); }
        public void SetCallbacks(IPunchActions instance)
        {
            if (m_Wrapper.m_PunchActionsCallbackInterface != null)
            {
                @Tap.started -= m_Wrapper.m_PunchActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_PunchActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_PunchActionsCallbackInterface.OnTap;
            }
            m_Wrapper.m_PunchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
            }
        }
    }
    public PunchActions @Punch => new PunchActions(this);

    // Wipes
    private readonly InputActionMap m_Wipes;
    private IWipesActions m_WipesActionsCallbackInterface;
    private readonly InputAction m_Wipes_smear;
    private readonly InputAction m_Wipes_smearL;
    public struct WipesActions
    {
        private @Controls m_Wrapper;
        public WipesActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @smear => m_Wrapper.m_Wipes_smear;
        public InputAction @smearL => m_Wrapper.m_Wipes_smearL;
        public InputActionMap Get() { return m_Wrapper.m_Wipes; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WipesActions set) { return set.Get(); }
        public void SetCallbacks(IWipesActions instance)
        {
            if (m_Wrapper.m_WipesActionsCallbackInterface != null)
            {
                @smear.started -= m_Wrapper.m_WipesActionsCallbackInterface.OnSmear;
                @smear.performed -= m_Wrapper.m_WipesActionsCallbackInterface.OnSmear;
                @smear.canceled -= m_Wrapper.m_WipesActionsCallbackInterface.OnSmear;
                @smearL.started -= m_Wrapper.m_WipesActionsCallbackInterface.OnSmearL;
                @smearL.performed -= m_Wrapper.m_WipesActionsCallbackInterface.OnSmearL;
                @smearL.canceled -= m_Wrapper.m_WipesActionsCallbackInterface.OnSmearL;
            }
            m_Wrapper.m_WipesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @smear.started += instance.OnSmear;
                @smear.performed += instance.OnSmear;
                @smear.canceled += instance.OnSmear;
                @smearL.started += instance.OnSmearL;
                @smearL.performed += instance.OnSmearL;
                @smearL.canceled += instance.OnSmearL;
            }
        }
    }
    public WipesActions @Wipes => new WipesActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPunchActions
    {
        void OnTap(InputAction.CallbackContext context);
    }
    public interface IWipesActions
    {
        void OnSmear(InputAction.CallbackContext context);
        void OnSmearL(InputAction.CallbackContext context);
    }
}
