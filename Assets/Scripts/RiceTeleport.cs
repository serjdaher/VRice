using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiceTeleport : MonoBehaviour
{
    private Vector3 initialPos;
    private Rigidbody rb;
    private void OnEnable()
    {
        //Physics.IgnoreLayerCollision(10, 10, true);
        Physics.IgnoreLayerCollision(10, 9, true);
        initialPos = transform.position;

        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 12)
        {
            rb.velocity = Vector3.zero;
            transform.position = initialPos;
            
        }
    }
}
