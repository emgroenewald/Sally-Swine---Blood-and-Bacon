using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PuzzleLogic : MonoBehaviour
{
    [SerializeField] string expectedObjectTag;
    [SerializeField] string slot;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(expectedObjectTag))
        {
            MainManager.Slots[slot] = true;
        }
        else
        {
            MainManager.Slots[slot] = false;
        }
    }
}

public class ScriptToCheckAllColors : MonoBehaviour
{
    private void MethodWhereYouWantToCheck()
    {
        bool canPass = MainManager.Slots["Red"] && MainManager.Slots["Blue"] && MainManager.Slots["Green"];
    }
}






