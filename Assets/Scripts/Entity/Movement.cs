using UnityEngine;

namespace Entity
{
    public class Movement : MonoBehaviour
    {
        public EntityController entityController;
    
        public float maxVelocity = 3;
        public float acceleration = 30;

        public Rigidbody rigidBody;

        private void FixedUpdate()
        {
            float fDeltaTime = Time.fixedDeltaTime;

            Vector3 realDirection =
                new Vector3(entityController.movementDirection.x, 0, entityController.movementDirection.y);

            Vector3 deltaVelocity = realDirection * (acceleration * fDeltaTime);
        
            if ((deltaVelocity + rigidBody.velocity).sqrMagnitude > maxVelocity * maxVelocity)
            {
                deltaVelocity *= (1f - (rigidBody.velocity.magnitude / maxVelocity));
            }
            rigidBody.velocity += deltaVelocity;
        }
    }
}
