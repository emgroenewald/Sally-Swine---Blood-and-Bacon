using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewBehaviourScript : MonoBehaviour
{

    public bool IsinRange;
    public string RequiredInventoryItem;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    void Start()
    {

    }

    void Update()
    {
        if (IsinRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsinRange = string.IsNullOrEmpty(RequiredInventoryItem) || MainManager.Inventory.Contains(RequiredInventoryItem);
            Debug.Log("Player now in range");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IsinRange = false;
            Debug.Log("Player now not in range");
    }
}