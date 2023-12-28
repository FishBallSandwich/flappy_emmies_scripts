using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Animator Transition;

    public void Awake()
    {
       Transition = GameObject.FindGameObjectWithTag("loader").GetComponent<Animator>();
    }
    

    public void PlayGame()
    {
        Debug.Log("Play button clicked");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int LevelIndex)
    {

        Transition.SetTrigger("out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(LevelIndex);

    }

    public void Options()
    {
        Debug.Log("Options not implemented yet");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");

    }
}