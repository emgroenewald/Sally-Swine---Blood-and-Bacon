using UnityEngine;

public class GavinSwineInteraction : MonoBehaviour
{
    public Animator gavinSwineAnimator;
    public string playerTag = "Player"; // Set the tag of the player in the Unity Editor

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider has the specified tag
        if (other.CompareTag(playerTag))
        {
            // Trigger the isKilled parameter in Gavin Swine's Animator controller
            gavinSwineAnimator.SetBool("isKilled", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Optional: Reset the isKilled parameter when the player exits the trigger zone
        if (other.CompareTag(playerTag))
        {
            gavinSwineAnimator.SetBool("isKilled", false);
        }
    }
}
