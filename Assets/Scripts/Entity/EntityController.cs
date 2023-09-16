using UnityEngine;

namespace Entity
{
    public abstract class EntityController : MonoBehaviour
    {
        [HideInInspector] public Vector2 movementDirection = new Vector2(0, 0);
        [HideInInspector] public Vector2 faceDirection = new Vector2(0, 0);
        [HideInInspector] public bool isSprinting = false;

        public Vector3 GetWorldFaceDirection()
        {
            return new Vector3(faceDirection.x, 0, faceDirection.y);
        }

        public Vector3 GetWorldMovementDirection()
        {
            return new Vector3(movementDirection.x, 0, movementDirection.y);
        }
    }
}
