using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
     public GameObject gameOverPanel;
 
    void Update()
    {
         if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            Invoke("displayPanel", 1);
            

        }
        
    }
    public void displayPanel()
    {
        gameOverPanel.SetActive(true);
    }
    public void Restart()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home()
    {

        SceneManager.LoadScene(0);
    }



}
