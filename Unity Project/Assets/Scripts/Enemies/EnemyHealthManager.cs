using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int enemyMaxHealth;
    public int enemyCurrentHealth;

    // Use this for initialization
    void Start() {
        enemyCurrentHealth = enemyMaxHealth;
    }

    // Update is called once per frame
    void Update() {

    }

    public void DamageEnemy(int damage) {
        enemyCurrentHealth -= damage;
        Debug.Log("currentHealth = " + enemyCurrentHealth);
        if (enemyCurrentHealth <= 0) {
            Destroy(gameObject);
        }
    }

    public void HealEnemy(int heal) {
        enemyCurrentHealth += heal;
        if (enemyCurrentHealth >= enemyMaxHealth) {
            enemyCurrentHealth = enemyMaxHealth;
        }
        Debug.Log("currentHealth = " + enemyCurrentHealth);
    }
}
