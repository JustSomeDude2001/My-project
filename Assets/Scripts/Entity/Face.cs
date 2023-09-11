using UnityEngine;

namespace Entity
{
    public class Face : MonoBehaviour
    {
        public EntityController entityController;

        public float rotationSpeed = 1;

        private void FixedUpdate()
        {
            Vector3 targetDirection = new Vector3(entityController.faceDirection.x, 0, entityController.faceDirection.y);
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation =
                Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
        }
    }
}
