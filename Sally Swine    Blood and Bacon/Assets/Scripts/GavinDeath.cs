using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GavinDeath : MonoBehaviour
{
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LoadScene();
    }

    // This method is called to load the scene
    void LoadScene()
    {
        SceneManager.LoadScene(18, LoadSceneMode.Single);
    }
}
