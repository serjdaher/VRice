using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Color initialColour;

    void OnEnable()
    {
        initialColour = GetComponent<Renderer>().material.color;
    }
    public void ColorChange(GameObject obj, Color newColour)
    {
        obj.GetComponent<Renderer>().material.color = newColour;
        StartCoroutine(FadeToInitialColor());
    }

    IEnumerator FadeToInitialColor()
    {
        yield return new WaitForSeconds(3f);
        this.GetComponent<Renderer>().material.color = initialColour;
    }

    
}
