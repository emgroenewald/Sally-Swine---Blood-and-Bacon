using UnityEngine;

public class PickUpText : MonoBehaviour
{
    [SerializeField]
    private Canvas pickUpCanvas;
    private bool pickUpAllowed;

    void Start()
    {
        // Ensure the canvas is initially hidden
        pickUpCanvas.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SetPickUpCanvas(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SetPickUpCanvas(false);
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

    private void SetPickUpCanvas(bool isActive)
    {
        pickUpCanvas.gameObject.SetActive(isActive);
    }

    private void PickUp()
    {
        // Add your pickup logic here
        Destroy(gameObject);
    }
}
