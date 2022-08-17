using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public Transform spawnMid;
    public Transform spawnMin;
    public Transform spawnMax;

    public GameObject enemy;

    public int delay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnenemy", 0f , delay);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void spawnenemy()
    {
        int randomPos = Random.Range(1,4);
        if(randomPos == 1)
        {
            Instantiate(enemy, spawnMid);
        }
        else if(randomPos == 2)
        {
            Instantiate(enemy, spawnMin);
        }
        else
        {
            Instantiate(enemy, spawnMax);
        }

    }
}
