using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (score).ToString("0");
    }
}
