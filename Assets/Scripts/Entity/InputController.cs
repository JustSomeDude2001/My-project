using UnityEngine;
using UnityEngine.InputSystem;

namespace Entity
{
    public class InputController : EntityController, PlayerActions.IDefaultActions
    {
        public Transform mainCamera;
    
        private PlayerActions _controls;

        private void OnEnable()
        {
            if (_controls != null)
                return;

            _controls = new PlayerActions();
            _controls.Default.SetCallbacks(this);
            _controls.Default.Enable();
        }

        public void OnDisable()
        {
            _controls.Default.Disable();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            var inputDirection = context.ReadValue<Vector2>();
            Vector3 realDirection = inputDirection.y * mainCamera.forward + inputDirection.x * mainCamera.right;
            movementDirection = (new Vector2(realDirection.x, realDirection.z)).normalized;
        }

        public void OnSprint(InputAction.CallbackContext context)
        {
            if (context.ReadValueAsButton())
            {
                isSprinting = true;
                Debug.Log("Started Sprinting");
            }
            else
            {
                isSprinting = false;
                Debug.Log("Stopped Sprinting");
            }
        }

        private void Update()
        {
            var forward = mainCamera.forward;
            faceDirection.x = forward.x;
            faceDirection.y = forward.z;
            faceDirection.Normalize();
        }
    }
}
