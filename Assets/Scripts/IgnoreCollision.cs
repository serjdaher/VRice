using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    [SerializeField] private GameObject hoe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreCollision(GetComponent<BoxCollider>(), hoe.gameObject.GetComponent<CapsuleCollider>(), true);
    }
}
