using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartChange : MonoBehaviour
{
    public int sceneBuildIndex;



    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
