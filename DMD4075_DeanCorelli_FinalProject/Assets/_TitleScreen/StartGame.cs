using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   // public void PlayGame()
  //  {
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   // }

    public string LevelName;

    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelName);
    }

}
