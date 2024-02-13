using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QTE_Ring : MonoBehaviour
{
    [SerializeField] public float fillAmount = 0;
    [SerializeField] public float timeThreshold = 0;
    public string eventSuccess = "no";
    public int sceneBuildIndex;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            // Debug.Log("press");
            fillAmount += .05f; 

        }

        timeThreshold += Time.deltaTime;

        if (timeThreshold>.1)
        {

            timeThreshold = 0;
            fillAmount -= .01f;
        }

        if(fillAmount<0)
        {
            fillAmount = 0;
        }


        if(fillAmount>=0.6)
        {
            timeThreshold = 0;
            fillAmount -= .00065f;
        }

        if(fillAmount>1)
        {
            eventSuccess = "yes";
            if (eventSuccess == "yes")
            {
                MainManager.Inventory.Add("DeadGavin");
                print("Switching scene to " + 13);
                
                SceneManager.LoadScene(13, LoadSceneMode.Single);

            }
            Debug.Log(eventSuccess);
        }

        GetComponent<Image>().fillAmount = fillAmount;
        
    }
}
