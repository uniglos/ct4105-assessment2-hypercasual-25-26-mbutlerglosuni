using UnityEngine;
using System.Collections;


public class GameOver : MonoBehaviour
{
    public float timer=0f;
    
    bool gameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer >= 6.9)
        {
            gameOver = true;
            
        }

        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "fish1" || other.tag == "fish2" || other.tag =="fish3" || other.tag=="fish4" || other.tag== "fish5")
        {
            
            timer += Time.deltaTime;
        }
       
    }
}
