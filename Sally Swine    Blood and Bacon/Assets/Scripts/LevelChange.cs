using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    public int sceneBuildIndex;
    public string RequiredInventoryItem;


    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");

        bool canChange = string.IsNullOrEmpty(RequiredInventoryItem) || MainManager.Inventory.Contains(RequiredInventoryItem);

        if(other.tag == "Player" && canChange)
        {
            print("Switching scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
