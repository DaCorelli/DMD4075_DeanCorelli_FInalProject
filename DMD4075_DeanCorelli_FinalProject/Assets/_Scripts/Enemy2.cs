using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{

    public Animator animator;

    public int maxHealth = 100;
    int currentHealth;

   // private UnityEngine.Object explosionRef;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        //explosionRef = Resources.Load("Explosion");
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Hurt2");

        if (currentHealth <= 0)
        {
            //GameObject explosion = (GameObject)Instantiate(explosionRef);
           // explosion.transform.position = new Vector3(transform.position.x, transform.position.y + .3f, transform.position.z);
            Die();
        }
    }

    void Die()
    {

        animator.SetBool("IsDead", true);


        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;


    }





}
