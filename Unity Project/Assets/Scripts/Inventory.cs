using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public Animator animator;
    private bool isInventoryDisplayed = false;
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
            isInventoryDisplayed = !isInventoryDisplayed;
            animator.SetBool("isInventoryDisplayed", isInventoryDisplayed);
            Debug.Log("Inventory key pressed! isDisplayed = " + isInventoryDisplayed);
        }
    }
}
