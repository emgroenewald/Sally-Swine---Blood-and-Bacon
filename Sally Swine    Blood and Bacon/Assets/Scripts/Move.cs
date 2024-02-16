using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] private UI_Inventory uiInventory;
    SpriteRenderer sprite;
    Rigidbody2D rb;
    Vector2 inputDir;

    Animator animator;

    private Inventory inventory;

    private void Awake()
    {
       

    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //if (inputDir.y > 0 && MainManager.Inventory.Contains("Bacon"))
        //    return;
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

        if (inputDir.x < 0 && sprite.flipX)
        {
            sprite.flipX = false;
        }
        if (inputDir.x > 0 && sprite.flipX)
        {
            sprite.flipX = true;
        }
    }
}
