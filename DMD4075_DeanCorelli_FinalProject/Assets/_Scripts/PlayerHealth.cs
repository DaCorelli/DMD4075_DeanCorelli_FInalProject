using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Rigidbody2D rb;

    public static int health = 10;
    public Image[] hearts;

    public Sprite fullHeart;

    public Sprite emptyHeart;

   // private void OnCollisionExit2D(Collision2D collision)
   // {
       // if (collision.collider.tag == "Enemy")
       // {
          //  health -= 5;
            
       // /}
        //
   // }

    // Update is called once per frame
    void Update()
    {
        foreach (Image img in hearts)
        {
            img.sprite = emptyHeart;
        }
        for (int i = 0; i < health; i++)
        {
            hearts[i].sprite = fullHeart;
        }
    }
}
