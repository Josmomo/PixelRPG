using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

	public Transform warpTarget;
    private ScreenFader screenFader;
    private PlayerController playerController;
    private Animator animator;


    IEnumerator OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Player") {
            screenFader = GameObject.FindGameObjectWithTag("ScreenFader").GetComponent<ScreenFader>();
            playerController = other.gameObject.GetComponent<PlayerController>();
            animator = other.gameObject.GetComponent<Animator>();

            // Disable animation and movement before fadeing out
            playerController.enabled = false;
            animator.enabled = false;
            yield return StartCoroutine(screenFader.FadeToBlack());

            Debug.Log("Warp");
            other.gameObject.transform.position = warpTarget.position;
            Camera.main.transform.position = warpTarget.position;

            // Enable animation and movement before fadeing in
            playerController.enabled = true;
            animator.enabled = true;
            yield return StartCoroutine(screenFader.FadeToClear());
        }
    }
}
