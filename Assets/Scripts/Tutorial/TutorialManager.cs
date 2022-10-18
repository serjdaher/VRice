using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    // Get all objects from the scene
    private GameObject[] _allObjects;

    private GameObject[] _plantCount;
    //private GameObject[] tilledCount;
    public GameObject clear;
    private float _clearTimer = 0.0f;

    [SerializeField] private GameObject _sphereFade1;
    [SerializeField] private GameObject _sphereFade2;


    // Start is called before the first frame update
    void Start()
    {


        // Get all objects that are tilled and disable their MeshRenderer at the start of the game.
        _allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        foreach (GameObject go in _allObjects)
        {
            if (go.layer == 8)
            {
                go.gameObject.GetComponent<MeshRenderer>().enabled = false;
            }
        }

        clear = GameObject.Find("Clear");
        clear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        _plantCount = GameObject.FindGameObjectsWithTag("SmallRicePlant");
        if (_plantCount.Length == 2)
        {
            clear.SetActive(true);
            _clearTimer += Time.deltaTime;
            if (_clearTimer >= 10.0f)
            {
                StartCoroutine(TransitionScene());
            }
        }
    }

    IEnumerator TransitionScene()
    {
        clear.SetActive(false);
        _sphereFade1.GetComponent<FadeScreen>().Fade(90f);
        _sphereFade2.GetComponent<FadeScreen>().Fade(90f);
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("GameScene1");
    }


}
