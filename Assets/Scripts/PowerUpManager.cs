using UnityEngine;


public class PowerUpManager : MonoBehaviour
{
   BallManager ballManager;

    void Start()
    {
        ballManager= GameObject.FindGameObjectWithTag("Ball").GetComponent<BallManager>();
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
