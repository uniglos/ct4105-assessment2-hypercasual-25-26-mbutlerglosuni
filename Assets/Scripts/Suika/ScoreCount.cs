using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score=0;
    public bool increase1 = false;
    public bool increase2 = false;
    public bool increase3 = false;
    public bool increase4 = false;
    public bool increase5 = false;
    public bool dropped=false;
    
    //for particles
    public GameObject plus1object;
    public GameObject plus10object;
    public GameObject plus20object;
    public GameObject plus30object;
    public GameObject plus40object;
    public GameObject plus100object;

    private ParticleSystem plus1;
    private ParticleSystem plus10;
    private ParticleSystem plus20;
    private ParticleSystem plus30;
    private ParticleSystem plus40;
    private ParticleSystem plus100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        plus1 = plus1object.GetComponent<ParticleSystem>();
        plus10 = plus10object.GetComponent<ParticleSystem>();
        plus20 = plus20object.GetComponent<ParticleSystem>();
        plus30 = plus30object.GetComponent<ParticleSystem>();
        plus40 = plus40object.GetComponent<ParticleSystem>();
        plus100 = plus100object.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (increase1)
        {
            score += 10;//increase score by 10 when the 1st fishes collide
            plus10.Play();
            increase1 = false;
        }
        if (increase2)
        {
            score += 20;//increase score by 20 when the 2nd fishes collide
            plus20.Play();
            increase2 = false;
        }
        if (increase3)
        {
            score += 30;//increase score by 30 when the 3rd fishes collide
            plus30.Play();
            increase3 = false;
        }
        if (increase4)//increase score by 40 when the 4th fishes collide
        {
            score += 40;
            plus40.Play();
            increase4 = false;
        }
        if (increase5)//increase score by 100 when two whales collide
        {
            score += 100;
            plus100.Play();
            increase5 = false;
        }
        if (dropped) //increase score by 1 when a fish is dropped
        {
            score += 1;
            plus1.Play();
            dropped = false;
        }
        
        
        scoreText.text = (score).ToString("0"); //display score with no decimals


    }
}
