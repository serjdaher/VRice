using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{

    public InputActionProperty pinchAnimationAction;
    public InputActionProperty clenchAnimationAction;

    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>(); // float because it's a trigger. If it was a button with a yes or no value, it would be bool.
        float gripValue = clenchAnimationAction.action.ReadValue<float>(); // float because it's a trigger. If it was a button with a yes or no value, it would be bool.
        handAnimator.SetFloat("Trigger", triggerValue);
        handAnimator.SetFloat("Grip", gripValue);
    }
}
