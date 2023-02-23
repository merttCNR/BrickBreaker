using UnityEngine;


public class BrickManager : MonoBehaviour
{
    public GameObject powerUp;
    float spawnPos;
    Vector3 spawnLoc;
   

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
