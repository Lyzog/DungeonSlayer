using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControll : MonoBehaviour
{
    public int hp = 100;

    public Transform firepoint;
    public GameObject bulletPrefab;

    public void Attack()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }

    public void PowerAttack()
    {
        
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject); // ska stänga av kontrollerna och visa resultat och en restart knapp eller knapp till menyn
    }
}
