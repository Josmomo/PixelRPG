using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed;

	private Rigidbody2D rigidbody2D;
	private Animator animator;
    private Vector2 vector2Movement;
    private float xPos;
    private float yPos;
    public bool isAttacking;

    // Use this for initialization
    void Start () {
        movementSpeed = 1;

        rigidbody2D = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
        isAttacking = false;
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        Attack();
	}

    private void Move() {
        // Normalize the vector for position but not for input
        xPos = Input.GetAxisRaw("Horizontal");
        yPos = Input.GetAxisRaw("Vertical");
        vector2Movement = new Vector2(xPos, yPos).normalized;

        if (vector2Movement != Vector2.zero) {
            animator.SetBool("isWalking", true);
            animator.SetFloat("input_x", xPos);
            animator.SetFloat("input_y", yPos);
        } else {
            animator.SetBool("isWalking", false);
        }
        
        rigidbody2D.MovePosition(rigidbody2D.position + vector2Movement * movementSpeed * Time.deltaTime);
    }

    private void Attack() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Attacking!");
            animator.SetBool("isAttacking", true);
            isAttacking = true;
        } else {
            animator.SetBool("isAttacking", false);
            isAttacking = false;
        }
    }

}
