using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
   BallManager ballManager;

    void Start()
    {
        ballManager= GameObject.FindGameObjectWithTag("Ball").GetComponent<BallManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Paddle")
        {

            ballManager.BallSpawn();
            Destroy(this.gameObject);


        }
    }

}
