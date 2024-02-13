using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneExit : MonoBehaviour
{
    public KeyCode exit;
    public int BackSceneId;
    public int SuccessScene;

    public void GoToSuccess()
    {
        SceneManager.LoadScene(SuccessScene, LoadSceneMode.Single);
    }
    
    void Update()
    {

        if (Input.GetKeyDown(exit))
        {
            SceneManager.LoadScene(BackSceneId, LoadSceneMode.Single);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
}
