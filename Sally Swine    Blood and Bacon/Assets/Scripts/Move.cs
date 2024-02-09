using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] private UI_Inventory uiInventory;

    Rigidbody2D rb;
    Vector2 inputDir;

    Animator animator;

    private Inventory inventory;

    private void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        rb.velocity = inputDir * speed;

        // Determine the animation parameters based on the vertical input direction
        if (animator != null)
        {
            bool isWalkingUp = inputDir.y > 0;
            bool isWalkingDown = inputDir.y < 0;

            animator.SetBool("walkingUp", isWalkingUp);
            animator.SetBool("walkingDown", isWalkingDown);

            // Set the general walking parameter
            animator.SetBool("isWalking", inputDir != Vector2.zero);
        }
    }

    public void SetInputDir(InputAction.CallbackContext context)
    {
        inputDir = context.ReadValue<Vector2>();
    }
}
