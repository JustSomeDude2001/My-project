using UnityEngine;

namespace Entity
{
    public class Movement : MonoBehaviour
    {
        public EntityController entityController;
    
        [SerializeField] private float maxVelocity = 3;
        [SerializeField] private float acceleration = 30;

        public Rigidbody rigidBody;

        public void SetMaxVelocity(float newMaxV)
        {
            maxVelocity = newMaxV;
            acceleration = maxVelocity * 1.5f;
        }

        public float GetMaxVelocity()
        {
            return maxVelocity;
        }
        
        private void FixedUpdate()
        {
            float fDeltaTime = Time.fixedDeltaTime;

            Vector3 realDirection = entityController.GetWorldMovementDirection();

            Vector3 deltaVelocity = realDirection * (acceleration * fDeltaTime);
        
            if ((deltaVelocity + rigidBody.velocity).sqrMagnitude > maxVelocity * maxVelocity)
            {
                deltaVelocity *= (1f - (rigidBody.velocity.magnitude / maxVelocity));
            }
            rigidBody.velocity += deltaVelocity;
        }
    }
}
