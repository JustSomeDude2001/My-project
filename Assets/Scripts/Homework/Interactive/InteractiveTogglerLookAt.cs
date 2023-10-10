using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTogglerLookAt : InteractiveToggler
{
    private Camera _mainCamera;
    
    public Collider lookAtTarget;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    protected override bool CheckInteraction()
    {
        if (!Input.GetKey(KeyCode.E))
        {
            return false;
        }
        if (!isInRange)
        {
            return false;
        }
        
        Vector3 point = new Vector3(_mainCamera.pixelWidth / 2, _mainCamera.pixelHeight / 2, 0);
        Ray ray = _mainCamera.ScreenPointToRay(point);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObject = hit.transform.gameObject;
            Collider target = hitObject.GetComponent<Collider>();
            return target == lookAtTarget;
        }

        return false;
    }
}
