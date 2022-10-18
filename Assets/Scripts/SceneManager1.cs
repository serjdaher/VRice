using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager1 : MonoBehaviour
{
    private GameObject[] allObjects;
    // Start is called before the first frame update
    void Start()
    {
        // Get all objects that are tilled and disable their MeshRenderer at the start of the game.
        allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        foreach (GameObject go in allObjects)
        {
            if (go.layer == 8)
            {
                go.gameObject.GetComponent<MeshRenderer>().enabled = false;
            }

        }
    }

        // Update is called once per frame
    void Update()
    {
    
    }
}
