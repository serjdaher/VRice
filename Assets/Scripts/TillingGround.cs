using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UntilledToTilled
{
    public class TillingGround : MonoBehaviour
    {
        public GameObject tilled;
        public GameObject hoe;

        // Start is called before the first frame update
        void Start()
        {
            //Turn off all the tilled pieces on Start.
            tilled.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter(Collision collider)
        {
            //Rigidbody rigidbodyHoe = hoe.GetComponent<Rigidbody>();
            //Check for a match with the specific tag on the GameObject that collides with your the untilled ground.
            if (collider.gameObject.GetComponentInChildren(typeof(BoxCollider), true))
            {
                gameObject.SetActive(false);
                tilled.SetActive(true);

            }
            else if (collider.gameObject.GetComponentInChildren(typeof(BoxCollider), false))
            {
                // We don't want the handle to collide with the ground and change the untilled pieces.
                Debug.Log("Nothing Happens");
            }
        }
    }
}

