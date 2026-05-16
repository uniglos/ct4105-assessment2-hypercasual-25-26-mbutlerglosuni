using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using System.Collections;

public class RandomSpawn : MonoBehaviour
{

    private float timer;
    private int pause =7;
    public GameObject fish1;//the fish that fall
    public GameObject fish2;
    public GameObject fish3;
    public GameObject fish1Still;//the still non-falling fish to show whats dropping next
    public GameObject fish2Still;
    public GameObject fish3Still;
    public int spawnRandom;
    bool fish1spawned = false; // bool to only spawn 1 fish
    bool fish2spawned = false;
    bool fish3spawned = false;
    public GameObject otter;
    

    public GameObject scoreManager;
    private ScoreCount scoreCount;

    private void Awake()
    {
        scoreManager = GameObject.Find("Score");
        scoreCount = scoreManager.GetComponent<ScoreCount>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0f;
        spawnRandom = Random.Range(1, 4);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        timer = timer + Time.deltaTime;
        
        
        
        if (spawnRandom == 1) // spawn fish 1
        {
            if (!fish1spawned )
            {
                
                Instantiate(fish1Still, new Vector3(transform.position.x+0.5f, transform.position.y, -4.9f), Quaternion.Euler(0, 0, 0), otter.transform); // spawn the not falling part
                fish1spawned = true;
                    
                
                
                

            }
            
            if (timer >= pause)
            {
                Destroy(GameObject.FindWithTag("Still"));

                Instantiate(fish1, new Vector3(transform.position.x+0.5f, transform.position.y, -4.9f), Quaternion.Euler(0, 0, 90)); // spawn the fish that falls
                timer = 0;
                
                scoreCount.dropped = true;
                spawnRandom = Random.Range(1, 4);
                fish1spawned = false;
                return;
            }
        }
        
        
        if (spawnRandom == 2 ) // spawn fish 2
        {
            if (!fish2spawned )
            {
                Instantiate(fish2Still, new Vector3(transform.position.x+0.5f, transform.position.y, -4.9f), Quaternion.Euler(0, 0, 0), otter.transform); // spawn the not falling part
                fish2spawned = true;

                
                
            }
                
            
            if (timer >= pause)
            {
                Destroy(GameObject.FindWithTag("Still"));

                Instantiate(fish2, new Vector3(transform.position.x+0.5f, transform.position.y, -4.9f), Quaternion.Euler(0, 0, 90)); // spawn the fish that falls
                timer = 0;
                
                scoreCount.dropped = true;
                spawnRandom = Random.Range(1, 4);
                fish2spawned = false;
                return;
            }
        }
        
        
        
        if (spawnRandom == 3) // spawn fish 3
        {
            if (!fish3spawned)
            {
                Instantiate(fish3Still, new Vector3(transform.position.x+0.5f, transform.position.y, -4.9f), Quaternion.Euler(0, 0, 0), otter.transform); // spawn the not falling part
                fish3spawned = true;

                
            }
            
            if (timer >= pause)
            {
                Destroy(GameObject.FindWithTag("Still"));

                Instantiate(fish3, new Vector3(transform.position.x+0.5f, transform.position.y, -4.9f), Quaternion.Euler(0, 0, 90)); // spawn the fish that falls
                timer = 0;
                
                scoreCount.dropped = true;
                spawnRandom = Random.Range(1, 4);
                fish3spawned = false;
                return; 
            }
        }
        
        }
}
