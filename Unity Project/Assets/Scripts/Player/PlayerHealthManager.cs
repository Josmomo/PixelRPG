using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHealth;
    public int playerCurrentHealth;

    // Use this for initialization
    void Start () {
        playerCurrentHealth = playerMaxHealth;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DamagePlayer(int damage) {
        playerCurrentHealth -= damage;
        Debug.Log("currentHealth = " + playerCurrentHealth);
        if (playerCurrentHealth <= 0) {
            Destroy(gameObject);
        }
    }

    public void HealPlayer(int heal) {
        playerCurrentHealth += heal;
        if (playerCurrentHealth >= playerMaxHealth) {
            playerCurrentHealth = playerMaxHealth;
        }
        Debug.Log("currentHealth = " + playerCurrentHealth);
    }
}
