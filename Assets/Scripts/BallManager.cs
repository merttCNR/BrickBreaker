using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject ballObject;
    Rigidbody2D rb;
    [SerializeField] float ballForce;
    public bool isDestroyed = false;
    public BrickManager brickManager;
    bool isballDest = false;
    public Vector2 hitPos;
    
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
     rb.AddForce(new Vector2(ballForce,ballForce));
    }

    // Update is called once per frame
    void Update()
    {
        PressScape();
    }

    private void PressScape()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.SetParent(null);
            rb.isKinematic= false;
            rb.AddForce(new Vector2(ballForce, ballForce));

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("DeadSq"))
        {
            Destroy(this.gameObject); //eðer diger instantiate edilen toplar yok olmassa toplara tag ata tag üzerinden yok et.
            isballDest= true;
        }

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Brick" )
        {
            other.gameObject.SetActive(false);
            
            
           // hitPos = this.transform.position;
            brickManager.Drop();

        }
        
    }

    


    public void BallSpawn()
    {
        if (isballDest == false)
        {
            Instantiate(ballObject, this.transform.position, Quaternion.identity);
        }
       
    }
}
