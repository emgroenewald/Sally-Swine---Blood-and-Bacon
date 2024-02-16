using UnityEngine;

public class KillMommyScript : MonoBehaviour
{
    // Fetch the Animator
    private Animator m_Animator;

    // Use this for deciding if the GameObject has killed mommy
    private bool m_KilledMom;

    void Start()
    {
        // Get the Animator, which should be attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();

        // The GameObject has not killed mommy initially
        m_KilledMom = false;
    }

    void Update()
    {
        // Press the "E" key to change the animation
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Toggle the value of m_KilledMom when the "E" key is pressed
            m_KilledMom = !m_KilledMom;

            // Set the Animator parameter "KilledMom" based on the current value
            m_Animator.SetBool("KilledMom", m_KilledMom);
        }
    }
}
