using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PuzzleLogic : MonoBehaviour
{
    [SerializeField] private bool FirstPuzzle = false;
    [SerializeField] private bool SecondPuzzle = false;
    [SerializeField] private bool ThirdPuzzle = false;

    // Variables to store the correct colors for each slot
    [SerializeField] private string correctColorForFirstSlot = "Red";
    [SerializeField] private string correctColorForSecondSlot = "Green";
    [SerializeField] private string correctColorForThirdSlot = "Blue";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string slotTag = collision.tag;

      
        switch (slotTag)
        {
            case "FirstSlot":
                HandleFirstSlot(collision);
                break;
            case "SecondSlot":
                HandleSecondSlot(collision);
                break;
            case "ThirdSlot":
                HandleThirdSlot(collision);
                break;
        }
    }

    private void HandleFirstSlot(Collider2D collision)
    {
        string enteredColor = collision.transform.tag;

        if (enteredColor == correctColorForFirstSlot)
        {
            FirstPuzzle = true;
            Debug.Log("Correct color placed in the first slot");
        }
        else
        {
            
            Debug.Log("Incorrect color for the first slot");
        }
    }

    private void HandleSecondSlot(Collider2D collision)
    {
        string enteredColor = collision.transform.tag;

        if (enteredColor == correctColorForSecondSlot)
        {
            SecondPuzzle = true;
            Debug.Log("Correct color placed in the second slot");
        }
        else
        {
           
            Debug.Log("Incorrect color for the second slot");
        }
    }

    private void HandleThirdSlot(Collider2D collision)
    {
        string enteredColor = collision.transform.tag;

        if (enteredColor == correctColorForThirdSlot)
        {
            ThirdPuzzle = true;
            Debug.Log("Correct color placed in the third slot");
        }
        else
        {
           
            Debug.Log("Incorrect color for the third slot");
        }
    }

}






