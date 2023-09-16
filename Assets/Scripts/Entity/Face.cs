using UnityEngine;

namespace Entity
{
    public class Face : MonoBehaviour
    {
        public EntityController entityController;

        public float rotationSpeed = 1;

        private void FixedUpdate()
        {
            Vector3 targetDirection = entityController.GetWorldFaceDirection();
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation =
                Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
        }
    }
}
