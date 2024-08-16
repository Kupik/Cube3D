using System;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasTrueOrFalse = false;

    public GameObject completeLevelUI;
    public float restartDelay = 1f;

    public void CompleteLevel() {

        completeLevelUI.SetActive(true);

    }
   
    public void EndGame ()
    {
        if(gameHasTrueOrFalse == false)
        {
            gameHasTrueOrFalse=true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

  

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
   
}
