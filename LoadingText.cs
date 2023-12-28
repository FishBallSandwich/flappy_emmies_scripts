using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadingTextAnimation : MonoBehaviour
{
    public TextMeshProUGUI LoadingText;
    private int DotsNumber = 0;
    private int MaxDotNumber = 6;
    private float DotInterval = 0.5f;
    private float timeSinceLastDot = 0f;

    void Update()
    {
        timeSinceLastDot += Time.deltaTime;

        if (DotsNumber < MaxDotNumber && timeSinceLastDot >= DotInterval)
        {
            DotsNumber++;
            string dots = new string('.', DotsNumber);
            LoadingText.text = "Loading" + dots;
            timeSinceLastDot = 0f;
        }

        if (DotsNumber >= MaxDotNumber)
        {
            DotsNumber = 0;
        }
    }
}
