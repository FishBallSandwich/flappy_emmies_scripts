using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float movespeed = 5;
    public float deadZone = -20;
    public float amplitude = 2; // Adjust this value to control the vertical oscillation amplitude
    public float frequency = 1; // Adjust this value to control the vertical oscillation frequency
    private float initialY;
    private float creationTime;
    private bool shouldOscillate = false;
    public LogicScript logic;




    private void Start()
    {
        initialY = transform.position.y; // Store the initial Y position of the pipe
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        if (logic.playerScore > 11 && logic.playerScore < 19)
        {
            shouldOscillate = true;
        }
        else
        {
            shouldOscillate = false;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();



        if (logic.playerScore > 11 && shouldOscillate)
        {
            // Move the pipe to the left
            transform.position += Vector3.left * movespeed * Time.deltaTime;

            // Calculate the vertical offset using a sine wave
            float yOffset = amplitude * Mathf.Sin(2 * Mathf.PI * frequency * Time.time);

            // Apply the vertical offset to the Y position
            transform.position = new Vector3(transform.position.x, initialY + yOffset, transform.position.z);

            if (transform.position.x < deadZone)
            {
                Debug.Log("Pipe Deleted");
                Destroy(gameObject);
            }
        }


        else
        {
            // Continue moving the pipe horizontally
            transform.position += Vector3.left * movespeed * Time.deltaTime;

            if (transform.position.x < deadZone)
            {
                Debug.Log("Pipe Deleted");
                Destroy(gameObject);
            }
        }
    }
}