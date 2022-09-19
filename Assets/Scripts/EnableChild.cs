using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnableChild : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void ActivatePlant(GameObject obj, int i)
    {
        if (obj.GetComponent<XRGrabInteractable>().isSelected)
        {
            obj.transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}

