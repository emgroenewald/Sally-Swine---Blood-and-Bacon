using UnityEngine;

public class KillMommyScript : MonoBehaviour
{

    
    private Animator m_Animator;

    private bool m_KilledMom;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();

        m_KilledMom = false;
    }

    void Update()
    {
        if (MainManager.Inventory.Contains("DeadMommy") && Input.GetKeyDown(KeyCode.E))
        {
            m_KilledMom = !m_KilledMom;

            m_Animator.SetBool("KilledMom", m_KilledMom);
        }
    }
}
