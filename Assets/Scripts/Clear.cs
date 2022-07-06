using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UntilledToTilled;

public class Clear : MonoBehaviour
{
    private GameObject[] tilledCount;
    public GameObject clear;
    private float clearTimer = 0.0f;

    public AudioClip groundHit;
    //public AudioClip clearFanfare;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        clear = GameObject.Find("Clear");
        clear.SetActive(false);

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        tilledCount = GameObject.FindGameObjectsWithTag("tilled");
        if (tilledCount.Length == 24)
        {
            clear.SetActive(true);
            clearTimer += Time.deltaTime;
            //audioSource.PlayOneShot(clearFanfare, 0.3f);
            if (clearTimer >= 10.0f)
            {
                clear.SetActive(false);
            }
        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("untilled"))
        {
            audioSource.PlayOneShot(groundHit, 0.6f);
        }
        
    }
}
