using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishLine : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator Transition;
    //public bool lineCrossed = false;
    

    void Start()
    {
        Transition = GameObject.FindGameObjectWithTag("loader").GetComponent<Animator>();
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //lineCrossed = true;
        Debug.Log("loading the game ending cutscene");
        StartCoroutine(LoadLevel());

    }

    IEnumerator LoadLevel()
    {

        Transition.SetTrigger("out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("cut scene");

    }



}

