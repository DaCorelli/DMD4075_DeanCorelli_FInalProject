using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicMovement : MonoBehaviour
{


    //  public GameObject bulletToRight, bulletToLeft;
    //  Vector2 bulletPos;
    //  public float fireRate = 0.5f;
    //  float nextFire = 0.0f;

    // bool facingRight = true;



    Vector2 move;  
    public int speed;  

  // public float MovementSpeed = 1;
  // public float JumpForce = 1;
   // private Rigidbody2D _rigidbody; 

    public bool isGrounded = false;

    public Animator animator;
  


    // Start is called before the first frame update
    void Start()
    {
        // _rigidbody = GetComponent<Rigidbody2D>();
       // DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    private void Update()
    {

       // var movement = Input.GetAxis("Horizontal");
       // transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        //if (!Mathf.Approximately(0, movement))
          //  transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

       // if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
       // {
          //  _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
       // }

        Jump();  

       // Play walking animations   
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));  


        //Left/Right Movemen
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

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 12f), ForceMode2D.Impulse);
        }

   
    }




}
