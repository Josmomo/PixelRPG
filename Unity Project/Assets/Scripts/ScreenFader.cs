using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFader : MonoBehaviour {

    public Animator animator;
    public bool isFading = false;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
    }

    public IEnumerator FadeToClear() {
        isFading = true;
        animator.SetTrigger("TriggerFadeIn");

        while (isFading) {
            yield return null;
        }
    }

    public IEnumerator FadeToBlack() {
        isFading = true;
        animator.SetTrigger("TriggerFadeOut");

        while (isFading) {
            yield return null;
        }
    }

    void AnimationComplete() {
        isFading = false;
    }
}
