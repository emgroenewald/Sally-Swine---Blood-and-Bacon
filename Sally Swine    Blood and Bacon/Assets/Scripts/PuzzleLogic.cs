using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleLogic : MonoBehaviour
{
    [SerializeField] string expectedObjectTag;
    [SerializeField] string slot;

    public UnityEvent OnSolved;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(expectedObjectTag))
        {
            MainManager.Slots[slot] = true;
            CheckIfAllFullfilled();
        }
        else
        {
            MainManager.Slots[slot] = false;
        }
    }

    private void CheckIfAllFullfilled()
    { 
        if(MainManager.Slots["Red"] && MainManager.Slots["Blue"] && MainManager.Slots["Green"])
        {
            MainManager.Inventory.Add("PuzzleKey");
            OnSolved?.Invoke();
        }
    }
}







