using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public Animator animator;
    private bool isDisplayed = false;
    private List<Item> items;

    private WeaponHandheld weaponHandheld;
    private WeaponThrowable weaponThrowable;
    private WeaponMagic weaponMagic;
    private Consumable consumable;

    private HeadGear headGear;
    private UpperBodyGear uppBodyGear;
    private LowerBodyGear lowerBodyGear;
    private FootGear footGear;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
        items = new List<Item>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.I)) {
            isDisplayed = !isDisplayed;
            animator.SetBool("isDisplayInventory", isDisplayed);
            Debug.Log("Inventory key pressed! isDisplayed = " + isDisplayed);
        }
    }
}
