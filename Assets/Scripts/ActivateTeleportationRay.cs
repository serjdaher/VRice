using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class ActivateTeleportationRay : MonoBehaviour
{
    //public GameObject leftTeleportation;
    public GameObject rightTeleportation;

    //public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    // Update is called once per frame
    void Update()
    {
        Vector2 rightActivateVector = rightActivate.action.ReadValue<Vector2>();
        //Vector2 leftActivateVector = leftActivate.action.ReadValue<Vector2>();

        //leftTeleportation.SetActive(leftActivateVector.y > 0.8f);
        rightTeleportation.SetActive(rightActivateVector.y > 0.8f);
    }
}

