using UnityEngine;


public class PaddleController : MonoBehaviour
{
    private float xMove;
    [SerializeField] float moveSpeed;
   


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
