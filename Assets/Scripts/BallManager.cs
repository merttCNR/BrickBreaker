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


    void Update()
    {
        PressSpace();
    }

    private void PressSpace()
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
            Destroy(this.gameObject);
            isballDest= true;
        }

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Brick" )
        {
            other.gameObject.SetActive(false);
            
            
           
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
