using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceKeySceneLoader : MonoBehaviour
{
    public int sceneBuildIndex; // Set the scene build index in the Unity Editor

    void Update()
    {
        // Check for the space key press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadScene();
        }
    }

    // This method is called to load the scene
    void LoadScene()
    {
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }
}
