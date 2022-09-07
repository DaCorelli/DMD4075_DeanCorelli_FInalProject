using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public int health = 100;
    int currentHealth;

    

    public Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
    }

   // public void TakeDamage(int damage)
   // {
     // currentHealth -= 5;

     // animator.SetTrigger("Pain");

        //if (currentHealth <= 0)
     //  {
        //    Die();
        //}
   // }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            health -= 5;
            
        }
        
    }



    void Die()
    {

        //animator.SetBool("IsDead", true);


        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
