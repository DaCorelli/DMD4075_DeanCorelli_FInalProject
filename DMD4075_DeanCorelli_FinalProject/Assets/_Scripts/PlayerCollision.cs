using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
                SceneManager.LoadScene("GameOver");
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

        if(collision.transform.tag == "Spike")
        {
            PlayerHealth.health--;
            if(PlayerHealth.health <= 0)
            {
                SceneManager.LoadScene("GameOver");
                gameObject.SetActive(false);
            }
            else
            {
                StartCoroutine(GetHurt());
            }
        }

        if(collision.transform.tag == "GameOver")
        {
            SceneManager.LoadScene("GameOver");
            PlayerHealth.health = 0;
            gameObject.SetActive(false);
        }
    
    }

    IEnumerator GetHurt()
    {
        Physics2D.IgnoreLayerCollision(6,9);
        GetComponent<Animator>().SetLayerWeight(1, 1);
        yield return new WaitForSeconds(3);
        GetComponent<Animator>().SetLayerWeight(1, 0);
        Physics2D.IgnoreLayerCollision(6, 9, false);
    }
}
