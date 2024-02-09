using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GavinDeath : MonoBehaviour
{
    public int sceneBuildIndex; // Set the scene build index in the Unity Editor

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LoadScene();
    }

    // This method is called to load the scene
    void LoadScene()
    {
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }
}
