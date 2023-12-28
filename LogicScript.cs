using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject GameOver;
    /* public bool LineCrossed;


     private void Update()
     {
         LineCrossed = GameObject.FindGameObjectWithTag("finishLine").GetComponent<FinishLine>();
     }
   */

    public void addScore()
    {
        playerScore = playerScore + 1;

        if (playerScore >= 0 && playerScore < 3)
        {
            //scoreText.text = "Intern aka Modern Slavery\n1 Rupee"; 
            scoreText.text = "Intern\nFor the Learnigns";
            

        }
        else if (playerScore >= 3 && playerScore < 7)
        {
            //scoreText.text = "Junior Manager\nPeanut Money";
            scoreText.text = "Junior Manager\nLive in a WG";
            
        }
        else if (playerScore >= 7 && playerScore < 11)
        {
            scoreText.text = "Manager\nLidl Shopper";
        }
        else if (playerScore >= 11 && playerScore < 15)
        {
            //scoreText.text = "Senior Manager\nMr.Lee Lunch Money";
            scoreText.text = "Senior Manager\nMoschMosch Lunch Money";
            
        }
        else if (playerScore >= 15 && playerScore < 19)
        {
            scoreText.text = "Senior Team Leader\nNerro Lunch Everyday";
        }
        else if (playerScore >= 19 && playerScore < 23)
        {
            scoreText.text = "Head\nEdeka Regular";
        }
        else if (playerScore >= 24 && playerScore < 28)
        {
            scoreText.text = "Director\nProperty Owner";
        }
        else if (playerScore >= 28 && playerScore < 32)
        {
            scoreText.text = "CEO\nThe Pinnacle of Food Chain";
        }
        else if (playerScore >= 32)
        {
            scoreText.text = "Super Emmie!\n Emma Stocks";
        }

        Debug.Log("the playScore is" + playerScore);
    }
    /* scoreText.text = playerScore.ToString(); */  


    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        GameOver.SetActive(true);
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
