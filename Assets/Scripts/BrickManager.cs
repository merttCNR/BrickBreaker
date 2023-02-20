using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    BallManager ballManager;
    public GameObject powerUp;
    void Start()
    {
        ballManager = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Drop()
    {
      float dropRate =  Random.Range(0, 100);

        if (dropRate > 50 )
        {
            
            Instantiate(powerUp,ballManager.hitPos,Quaternion.identity);

        }
    }
}
