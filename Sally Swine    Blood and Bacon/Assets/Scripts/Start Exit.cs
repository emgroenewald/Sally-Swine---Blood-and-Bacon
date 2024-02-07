using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeExit : MonoBehaviour
{
    void Update()
    {
        // Check for the space key press
        if (Input.GetKeyDown(KeyCode.E))
        {
            Application.Quit();
        }
    }

}
