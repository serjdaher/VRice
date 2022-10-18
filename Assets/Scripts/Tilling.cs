using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Tilling : MonoBehaviour
{
    [SerializeField] private ParticleSystem debris;
    private AudioSource _tillingSound;

    private void Start()
    {
        _tillingSound = GetComponent<AudioSource>();
        Physics.IgnoreLayerCollision(3, 9, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Get the position of the collided object
        Vector3 collisionPosition = collision.gameObject.transform.position;

        if (collision.gameObject.layer == 8 && collision.gameObject.GetComponent<MeshRenderer>().enabled == false)
        {
            _tillingSound.Play();
            DebrisHit(collisionPosition);

            if (GetComponent<Rigidbody>().velocity.magnitude > 47f)
            {
                collision.gameObject.GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }

    private void DebrisHit(Vector3 position)
    {
        debris.transform.position = position;
        debris.GetComponent<ToggleParticle>().Play();
    }
}
