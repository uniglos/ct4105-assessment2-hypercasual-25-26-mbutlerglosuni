using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HookBaitCount : MonoBehaviour
{
    public int baitAmount=10;
    public int scoreCount = 0;
    public TextMeshProUGUI baitText;
    public TextMeshProUGUI scoreText;
    public bool decreaseBait = false;

    public AudioSource audio;

    //for particles
    public GameObject objectplus1;
    public GameObject objectplus2;
    public GameObject objectplus3;
    public GameObject objectplus4;
    public GameObject objectplus5;
    public GameObject objectplus10;
    public GameObject objectplus17;
    public GameObject objectplus24;
    public GameObject objectplus31;
    public GameObject objectplus45;

    public ParticleSystem plus1;
    public ParticleSystem plus2;
    public ParticleSystem plus3;
    public ParticleSystem plus4;
    public ParticleSystem plus5;
    public ParticleSystem plus10;
    public ParticleSystem plus17;
    public ParticleSystem plus24;
    public ParticleSystem plus31;
    public ParticleSystem plus45;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //all the particles sigh
        plus1 = objectplus1.GetComponent<ParticleSystem>();
        plus2 = objectplus2.GetComponent<ParticleSystem>();
        plus3 = objectplus3.GetComponent<ParticleSystem>();
        plus4 = objectplus4.GetComponent<ParticleSystem>();
        plus5 = objectplus5.GetComponent<ParticleSystem>();
        plus10 = objectplus10.GetComponent<ParticleSystem>();
        plus17 = objectplus17.GetComponent<ParticleSystem>();
        plus24 = objectplus24.GetComponent<ParticleSystem>();
        plus31 = objectplus31.GetComponent<ParticleSystem>();
        plus45 = objectplus45.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        baitText.text = (baitAmount).ToString("0");
        scoreText.text = (scoreCount).ToString("0");
        if (baitAmount <= 0)
        {
            SceneManager.LoadScene("GameOverFishing");
        }
  
    }
    private void FixedUpdate()
    {
        if (decreaseBait)
        {
            baitAmount -= 1;
            decreaseBait = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("fish1"))
        {
            baitAmount += 5;
            scoreCount += 45;
            plus5.Play();
            plus45.Play();
        }
        if (collision.gameObject.CompareTag("fish2"))
        {
            baitAmount += 4;
            scoreCount += 31;
            plus4.Play();
            plus31.Play();
        }
        if (collision.gameObject.CompareTag("fish3"))
        {
            baitAmount += 3;
            scoreCount += 24;
            plus3.Play();
            plus24.Play();
        }
        if (collision.gameObject.CompareTag("fish4"))
        {
            baitAmount += 2;
            scoreCount += 17;
            plus2.Play();
            plus17.Play();
        }
        if (collision.gameObject.CompareTag("fish5"))
        {
            baitAmount += 1;
            scoreCount += 10;
            plus1.Play();
            plus10.Play();
            
        }
        audio.Play();
    }
}
