using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;


public class TeleportController : MonoBehaviour
{
    public GameObject baseControllerGameObject;
    public GameObject teleportationGameObject;

    public InputActionReference teleportActivationReference;

    [Space]
    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    private void Start()
    {
        teleportActivationReference.action.performed += TeleportModeActivate;
        teleportActivationReference.action.canceled += TeleportModeCancel;

    }

    
    private void TeleportModeActivate(InputAction.CallbackContext obj)
    {
        //if(onTeleportActivate != null)
        //{
        //    onTeleportActivate.Invoke();
        //} 
        onTeleportActivate?.Invoke();
    }

    private void TeleportModeCancel(InputAction.CallbackContext obj)
    {
        Invoke("DeactivateTeleporter", 0.02f);
    }

    void DeactivateTeleporter()
    {
        //if(onTeleportCancel != null)
        //{
        //    onTeleportCancel.Invoke();
        //}
        onTeleportCancel?.Invoke();
    }
}
