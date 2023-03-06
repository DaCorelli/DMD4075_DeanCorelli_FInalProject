using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void LoadGame()
    {
        // SceneManager.LoadScene("Level 1");
        SceneManager.LoadScene("Title");
        PlayerHealth.health = 15;
    }


}
