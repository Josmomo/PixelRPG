using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour {

    protected string title;
    private string description;
    private Sprite image;
    private bool isStackable = false;
    private int amount = 1;
    private bool isConsumable = false;


	// Use this for initialization
	void Start () {
        // TODO load data from database
        title = "item0";
        description = "description0";

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public abstract void Use();
}
