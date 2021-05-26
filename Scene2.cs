using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded:" + scene.name);
        if (scene.name == "Scene1")
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Scene1"));
            SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Scene2"));
        }
    }
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void GoToScene2()
    {
        SceneManager.LoadScene("Scene1", LoadSceneMode.Additive);
    }
}
