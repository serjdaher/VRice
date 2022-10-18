using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private GameObject _sphereFade1;
    [SerializeField] private GameObject _sphereFade2;

    public void SceneToLoad(string sceneName)
    {
        StartCoroutine(SceneLoad(sceneName));
    }

    IEnumerator SceneLoad(string sceneName)
    {
        _sphereFade1.GetComponent<FadeScreen>().Fade(90f);
        _sphereFade2.GetComponent<FadeScreen>().Fade(90f);
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(sceneName);
    }

}
