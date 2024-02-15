using UnityEngine;

public class PickUpText : MonoBehaviour
{
    [SerializeField]
    private Canvas pickUpCanvas;
    private bool pickUpAllowed;
    public string inventoryName;
    public string RequiredInventoryItem;
    public Renderer spriteRenderer;

    void Start()
    {
        //pickUpCanvas.gameObject.SetActive(false);
       
    }
    private void Awake()
    {
        spriteRenderer.enabled = !MainManager.Inventory.Contains(inventoryName);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            //SetPickUpCanvas(true);
            pickUpAllowed = string.IsNullOrEmpty(RequiredInventoryItem) || MainManager.Inventory.Contains(RequiredInventoryItem);
            // pickUpAllowed = MainManager.Inventory.Contains("Cheese");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //SetPickUpCanvas(false);
            pickUpAllowed = false;
        }
    }

    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }
    }

    //private void SetPickUpCanvas(bool isActive)
    //{
    //    pickUpCanvas.gameObject.SetActive(isActive);
    //}

    private void PickUp()
    {
        // Add your pickup logic here
        MainManager.Inventory.Add(inventoryName);
        Destroy(gameObject);
    }
}
