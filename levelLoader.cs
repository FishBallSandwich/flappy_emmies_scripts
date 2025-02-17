using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 2f;
    void Update()
    {

        LoadNextLevel();

    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }


    IEnumerator LoadLevel(int levelIndex)

    {
        transition.SetTrigger("start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);


    }
     


}
