using UnityEngine;

public class PuzzleLogic : MonoBehaviour
{
    [SerializeField] string expectedColor;
    [SerializeField] string slot;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("expectedColor"))
        {
            MainManager.Slots[slot] = true;
        }
        else
        {
            MainManager.Slots[slot] = false;
        }
    }
}