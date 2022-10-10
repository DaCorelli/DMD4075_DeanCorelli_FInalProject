using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator animator;

    public int maxHealth = 100;
    int currentHealth;
    private UnityEngine.Object explosionRef;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        explosionRef = Resources.Load("Explosion");
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Hurt");

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
       Debug.Log("enemy died");

        GameObject explosion = (GameObject)Instantiate(explosionRef);
        explosion.transform.position = new Vector3(transform.position.x, transform.position.y + .3f, transform.position.z);

        animator.SetBool("IsDead", true);

       
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false; 
        this.enabled = false;


   }





}
