using UnityEngine;
using UnityEngine.SceneManagement;

public class Back2Menu : MonoBehaviour
{
    
    void Update()
    {
        Backtomenu();
    }


    private void Backtomenu()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        
    }
}
