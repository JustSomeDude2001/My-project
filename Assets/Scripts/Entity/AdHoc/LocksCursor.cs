using System;
using UnityEngine;

namespace Entity
{
    public class LocksCursor : MonoBehaviour
    {
        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void OnDestroy()
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}