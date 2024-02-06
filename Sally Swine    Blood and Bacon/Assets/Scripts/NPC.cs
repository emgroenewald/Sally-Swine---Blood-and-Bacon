using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue;
    private int index;

    public float letterSpeed = 0.05f;
    private bool playerIsClose;
    private bool isDialogueActive = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
            StartDialogue();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            StopCoroutine(DisplayDialogue());
        }
    }

    void StartDialogue()
    {
        if (!isDialogueActive)
        {
            dialoguePanel.SetActive(true);
            StartCoroutine(DisplayDialogue());
        }
    }

    IEnumerator DisplayDialogue()
    {
        isDialogueActive = true;

        for (index = 0; index < dialogue.Length; index++)
        {
            dialogueText.text = "";

            for (int j = 0; j < dialogue[index].Length; j++)
            {
                dialogueText.text += dialogue[index][j];
                yield return new WaitForSeconds(letterSpeed);
            }

            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));
        }

        // Ensure that the player presses 'E' to continue after the last dialogue
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));

        dialoguePanel.SetActive(false);
        isDialogueActive = false;

        // Now, after the entire dialogue is completed, destroy the GameObject
        Destroy(gameObject);
    }
}
