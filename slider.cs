using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class sliderController : MonoBehaviour
{
    public Slider slider;
    public float sliderDuration = 6f;
    private float elapsedTime = 0f;
    public Animator Transition;




   
    void Start()
    {
        Transition = GameObject.FindGameObjectWithTag("loader").GetComponent<Animator>();
        slider.value = 0;
        StartCoroutine(FillSlider());
    }

    IEnumerator FillSlider()
    {
        while (elapsedTime < sliderDuration)
        {
            slider.value = Mathf.Lerp(0, 1, elapsedTime / sliderDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        slider.value = 1f;
        yield return StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }



    IEnumerator LoadLevel(int LevelIndex)
    {

        Transition.SetTrigger("out");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(LevelIndex);

    }

    


}
