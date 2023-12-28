using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineSpawner : MonoBehaviour
{

    public GameObject finishLine;
    public LogicScript logic;
    private int PlayerScore;
    private bool LineSpawned = false;

    void Start()
    {
        
    }

    void Update()
    {
        PlayerScore = logic.playerScore;
        if (PlayerScore == 33 && !LineSpawned)
        {
            Instantiate(finishLine, transform.position, transform.rotation);
            LineSpawned = true;
        }
        else { }
    }
    
}

