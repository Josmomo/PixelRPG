using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rigidbody2D;
	Animator animator;

	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 vector2Movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

		if (vector2Movement != Vector2.zero) {
			animator.SetBool("isWalking", true);
			animator.SetFloat("input_x", vector2Movement.x);
			animator.SetFloat("input_y", vector2Movement.y);
		} else {
			animator.SetBool("isWalking", false);
		}

		rigidbody2D.MovePosition(rigidbody2D.position + vector2Movement * Time.deltaTime);
	}
}
