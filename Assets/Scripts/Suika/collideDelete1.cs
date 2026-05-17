using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class collideDelete1 : MonoBehaviour
{
    public bool doNothing;
    public GameObject fish2;
    
    public GameObject scoreManager;
    private ScoreCount scoreCount;

    public AudioSource audio;

    private void Awake()
    {
        scoreManager = GameObject.Find("Score");
        scoreCount = scoreManager.GetComponent<ScoreCount>();
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fish1")
        {
            
            if (doNothing) return;

            //destroys the first
            
            
            collision.gameObject.GetComponent<collideDelete1>().doNothing = true;
            
            Destroy(collision.gameObject);


            scoreCount.increase1 = true;


            //destroys the second and spawns a new fish
            Instantiate(fish2, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, -90));
            

            Destroy(gameObject);

        }
        
            audio.Play();
        
    }
}
