using UnityEngine;

namespace Entity
{
    public abstract class EntityController : MonoBehaviour
    {
        [HideInInspector] public Vector2 movementDirection = new Vector2(0, 0);
        [HideInInspector] public Vector2 faceDirection = new Vector2(0, 0);
    }
}
