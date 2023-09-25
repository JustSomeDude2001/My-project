using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookY : MonoBehaviour
{
    public float sensitivityVer = 3.0f;

    // Update is called once per frame
    void Update()
    {
        float verticalRot = Input.GetAxis("Mouse Y") * sensitivityVer;
        transform.Rotate(-verticalRot, 0, 0, Space.Self);
    }
}