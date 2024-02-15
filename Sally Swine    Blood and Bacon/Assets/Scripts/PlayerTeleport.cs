using System.Collections;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private GameObject currentTeleporter;

    void Start()
    {

    }

    void Update()
    {
        if (currentTeleporter != null)
        {
            StartCoroutine(TeleportWithDelay(currentTeleporter.GetComponent<Teleport>().GetDestination().position, 1f));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            if (collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }

    IEnumerator TeleportWithDelay(Vector3 destination, float delay)
    {
        yield return new WaitForSeconds(delay);
        transform.position = destination;
    }
}
