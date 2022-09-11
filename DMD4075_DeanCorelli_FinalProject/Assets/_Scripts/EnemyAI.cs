using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float timeBTWShots;
    public float shootSpeed;

    public GameObject bullet;

    [SerializeField]
    Transform player;

    public Transform shootPos;

    [SerializeField]
    float agroRange, Stop;

    [SerializeField]
    float fireRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;

    public bool canShoot;

   

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        canShoot = true; 
    }

    // Update is called once per frame
    void Update()
    {
        //distance to player 
        float distToPlayer = Vector2.Distance(transform.position, player.position);


        if(distToPlayer <= fireRange)
        {
            if(canShoot)
            StartCoroutine(Attack());

          
        }

        if (distToPlayer < agroRange) 
        {
            //chase player
            ChasePlayer();
        }

        if(distToPlayer > Stop)
        {
            StopChasingPlayer();
        }
     
     
    }

    IEnumerator Attack()
    {

        canShoot = false; 

        yield return new WaitForSeconds(timeBTWShots);
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);

        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * moveSpeed *Time.fixedDeltaTime, 0f);
        Debug.Log("Shoot");

        canShoot = true; 

    }


    void StopChasingPlayer()
    {
        rb2d.velocity = new Vector2(0, 0);
  
    }

    void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            rb2d.velocity = new Vector2(moveSpeed, 0);
            transform.localScale = new Vector2(-1, 1);
            
        }
        else 
        {

            rb2d.velocity = new Vector2(-moveSpeed, 0);
            transform.localScale = new Vector2(1, 1);
        }
    }
}
