using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PaddleController : MonoBehaviour
{
    private float xMove;
    [SerializeField] float moveSpeed;
    private Rigidbody2D rb;
    private Collider2D col;



    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();   
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PaddleMove();
    }

    private void PaddleMove()
    {
        xMove = Input.GetAxis("Horizontal");
        Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -2.3f, 2.3f);
        transform.position = pos;
        xMove *= moveSpeed * Time.deltaTime;
        Vector3 moveDir = new Vector3 (xMove, 0, 0);
        

        transform.Translate(moveDir);
        
    }

}
