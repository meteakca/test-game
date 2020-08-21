using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Music : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("LoadFirstScene", 3);
    }


    private void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
