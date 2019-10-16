using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public int hp = 100;
    public int damage = 10;

    // public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if(hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Instantiate(deathEffect, transform.position, Quaternion.identity); // gör en dödsanimation om man har en
        Destroy(gameObject);
    }
}
