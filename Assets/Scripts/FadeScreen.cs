using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScreen : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fade(float rotation)
    {
        StartCoroutine(FadeRoutine(rotation));
    }

    public IEnumerator FadeRoutine(float rotation)
    {
        Quaternion fromRotation = transform.rotation;

        ////This method  is in case we want to substract the vectors manually)
        //Quaternion toRotation = Quaternion.Euler(Vector3.up + Vector3.back);

        // This method takes a rotation as argument and interpolates the current rotation to the new rotation.
        Quaternion toRotation = Quaternion.Euler(transform.rotation.x + (rotation * (Mathf.PI / 180)), transform.rotation.y, transform.rotation.z);
        for (float t = 0f; t < 1f; t += speed * Time.deltaTime)
        {
            transform.rotation = Quaternion.Lerp(fromRotation, toRotation, t);
            yield return null;
        }
        transform.rotation = toRotation;
    }
}
