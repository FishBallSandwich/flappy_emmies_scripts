using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float height = 8;
    public LogicScript logic;
    private int PlayerScore;
    private float lowestPoint;
    private float highestPoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }


    // Update is called once per frame
    void Update()

        
    {
        int PlayerScore = logic.playerScore;
        if (PlayerScore >= 7 && PlayerScore < 19)
        {
            spawnRate = 1.25f;
        }

        else if (PlayerScore >= 19 && PlayerScore <= 28)

        {
            spawnRate = 0.75f;
        }

        else if (PlayerScore > 28)
        {
            spawnRate = 0.3f;                      
        }

        else
        {
            spawnRate = 2;
        }


        if (timer < spawnRate)
        {

            timer += Time.deltaTime;

        }
        else
        {
            spawnPipe();
            timer = 0;

        }
    }

    void spawnPipe()
    {


        int PlayerScore = logic.playerScore;
        if (PlayerScore < 33)
        {
            if (PlayerScore > 15)
            {
                lowestPoint = (transform.position.y - height) / 3;
                highestPoint = (transform.position.y + height) / 3;
            }

            else if (PlayerScore >= 28)
            {
                lowestPoint = (transform.position.y - height) / 12;
                highestPoint = (transform.position.y + height) / 12;
            }

            else
            {
                lowestPoint = transform.position.y - height;
                highestPoint = transform.position.y + height;
            }


            Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }

        else { } //pass, dont spawn pipe
    }
}