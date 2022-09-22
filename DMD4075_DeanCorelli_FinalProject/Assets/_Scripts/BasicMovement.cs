using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{


    //  public GameObject bulletToRight, bulletToLeft;
    //  Vector2 bulletPos;
    //  public float fireRate = 0.5f;
    //  float nextFire = 0.0f;

    // bool facingRight = true;

    

    Vector2 move;
    public int speed;

    public bool isGrounded = false;

    public Animator animator;

    private bool m_FacingRight = true; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        Jump();

        //Play walking animations 
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));


        //Left/Right Movement
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        transform.position += new Vector3(move.x, move.y, 0) * speed * Time.deltaTime;

        transform.Translate(move * speed * Time.deltaTime);

      //  if(Input.GetMouseButtonDown(0) && Time.time > nextFire)
      //  {
          //  nextFire = Time.time + fireRate;
           // fire();
     //   }


       // Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        //transform.position = transform.position + horizontal * Time.deltaTime;

    }
    void Jump()
    {
        if (Input.GetKeyDown("w") && isGrounded == true)
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 13f), ForceMode2D.Impulse);
        }

   
    }

    private void Flip()
    {
        m_FacingRight = !m_FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }



}
