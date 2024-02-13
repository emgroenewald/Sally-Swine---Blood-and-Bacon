using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LevelChange : MonoBehaviour
{
    public int sceneBuildIndex;
    public Vector3 SallyPosition;
    public Vector3 SallyAltPosition;
    public string RequiredInventoryItem;
    public int altSceneIndex =-1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");

        bool canChange = string.IsNullOrEmpty(RequiredInventoryItem) || MainManager.Inventory.Contains(RequiredInventoryItem);

        if (other.tag == "Player" && canChange)
        {
            print("Switching scene to " + sceneBuildIndex);
            
            MainManager.SallyPosition = SallyPosition;
            
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
        else if (other.tag == "Player" && altSceneIndex > -1)
        {
            MainManager.SallyPosition = SallyAltPosition;
            SceneManager.LoadScene(altSceneIndex, LoadSceneMode.Single);
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
