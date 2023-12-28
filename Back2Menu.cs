using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back2Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Go back to Main Menu");
        SceneManager.LoadScene("MenuScene");
    }

}

