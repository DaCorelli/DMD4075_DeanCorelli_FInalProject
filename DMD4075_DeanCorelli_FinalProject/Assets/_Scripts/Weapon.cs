using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    
    public Transform firePoint;
   // public GameObject bulletPrefab;
    public int damage = 40;

    public Bullet ProjectilePrefab;

    //public LineRenderer lineRenderer;

  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // StartCoroutine (Shoot());
            Shoot();
        }

      

    }

    void Shoot()
    {
        Instantiate(ProjectilePrefab, firePoint.position, transform.rotation);
    }

   // IEnumerator Shoot()
   // {
        //shooting logic 
        //  Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

      ////////////////// RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

       // RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, Vector2.right * new Vector2(characterDirection,0f))




       // if (hitInfo)
       // {
           // //Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            //if (enemy != null)
           // {
            //    enemy.TakeDamage(damage);
          //  }

          //  lineRenderer.SetPosition(0, firePoint.position);
           // lineRenderer.SetPosition(1, hitInfo.point);
       // }
       // else
      //  {
          //  lineRenderer.SetPosition(0, firePoint.position);
           // lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);
      //  }

       // lineRenderer.enabled = true;

       // yield return new WaitForSeconds(0.02f);

       // lineRenderer.enabled = false;
  //  }








}

