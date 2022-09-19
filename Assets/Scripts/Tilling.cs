using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tilling : MonoBehaviour
{
    // Get all objects from the scene
    private GameObject[] allObjects;

    private GameObject[] plantCount;
    //private GameObject[] tilledCount;
    public GameObject clear;
    private float clearTimer = 0.0f;

    private void Start()
    {
        Physics.IgnoreLayerCollision(3, 9, true);
        // Get all objects that are tilled and set them to false at the start of the game.
        allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        foreach (GameObject go in allObjects)
        {
            if(go.layer == 8)
            {
                go.gameObject.SetActive(false);
            }
        }

        clear = GameObject.Find("Clear");
        clear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        plantCount = GameObject.FindGameObjectsWithTag("SmallRicePlant");
        if (plantCount.Length == 12)
        {
            clear.SetActive(true);
            clearTimer += Time.deltaTime;
            if (clearTimer >= 10.0f)
            {
                clear.SetActive(false);
                SceneManager.LoadScene("GameScene1");
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 7 && GetComponent<Rigidbody>().velocity.magnitude > 47f)
        {
            collision.transform.GetChild(0).gameObject.SetActive(false);
            collision.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
