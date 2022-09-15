using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            PlayerHealth.health--;
            if(PlayerHealth.health <= 0)
            {
                //PlayerManager.isGameOver = true;
                gameObject.SetActive(false);
            }
            else
            {
                StartCoroutine(GetHurt());
            }
        }

        if(collision.transform.tag == "slimeBall")
        {
            PlayerHealth.health--;
        }
    }

    IEnumerator GetHurt()
    {
        Physics2D.IgnoreLayerCollision(6,9);
        yield return new WaitForSeconds(3);
        Physics2D.IgnoreLayerCollision(6, 9, false);
    }
}
