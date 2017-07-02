using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed;

	private Rigidbody2D rigidbody2D;
	private Animator animator;
    private Vector2 vector2Movement;
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
        vector2Movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        if (vector2Movement != Vector2.zero) {
            animator.SetBool("isWalking", true);
            animator.SetFloat("input_x", vector2Movement.x);
            animator.SetFloat("input_y", vector2Movement.y);
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
