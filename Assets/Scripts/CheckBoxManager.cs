using UnityEngine;

public class CheckBoxManager : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public int count ;

    void Start()
    {
        count = 176;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Brick")
        {
            count--;
            if (count == 0)
            {
                Time.timeScale = 0;
                
                gameOverCanvas.gameObject.SetActive(true);
            }
           
        }
    }
}
