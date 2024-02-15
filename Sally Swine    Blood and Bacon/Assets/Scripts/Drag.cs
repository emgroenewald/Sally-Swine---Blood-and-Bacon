using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Drag : MonoBehaviour
{
    public string inventoryItem;
    private bool dragging = false;
    private Vector3 offset;
    public Renderer item;

    // Start is called before the first frame update
    private void Awake()
    {
        
        item.enabled = MainManager.Inventory.Contains(inventoryItem);
    }

    // Update is called once per frame
    void Update()
    {
        if(dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }
    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }
    private void OnMouseUp()
    {
        dragging = false;
    }
}
