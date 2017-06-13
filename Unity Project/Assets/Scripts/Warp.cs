using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

	public Transform warpTarget;

	IEnumerator OnTriggerEnter2D(Collider2D other) {

        ScreenFader screenFader = GameObject.FindGameObjectWithTag("ScreenFader").GetComponent<ScreenFader>();

        yield return StartCoroutine(screenFader.FadeToBlack());

		Debug.Log("Collision");
		other.gameObject.transform.position = warpTarget.position;
		Camera.main.transform.position = warpTarget.position;

        yield return StartCoroutine(screenFader.FadeToClear());
    }
}
