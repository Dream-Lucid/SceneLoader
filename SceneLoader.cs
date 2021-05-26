using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Scene1", LoadSceneMode.Additive);
    }

}
