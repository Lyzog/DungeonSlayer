using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;

    public Rigidbody2D rb;
    // public GameObject impactEffect;

    private void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        MonsterController monster = hitInfo.GetComponent<MonsterController>();
        if(monster != null)
        {
            monster.TakeDamage(damage);
        }
        // Instantiate(impactEffect, transform.position, transform.rotation); // gör en effect om man har en

        CharacterControll character = hitInfo.GetComponent<CharacterControll>();
        if(character != null)
        {
            character.TakeDamage(damage);
        }
        Destroy(gameObject);
    }



}
