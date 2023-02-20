using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    BallManager ballManager;
    public GameObject powerUp;
    float spawnPos;
    Vector3 spawnLoc;
    void Start()
    {
        ballManager = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallManager>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnPos = Random.Range(-2.5f, 2.5f);
        spawnLoc = new Vector3(spawnPos, 0f, 0f);

    }


    public void Drop()
    {
      float dropRate =  Random.Range(0, 100);

        if (dropRate > 90 )
        {
            
            Instantiate(powerUp,spawnLoc,Quaternion.identity);

        }
    }
}
