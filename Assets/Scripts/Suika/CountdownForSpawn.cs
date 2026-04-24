using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CountdownForSpawn : MonoBehaviour
{
    public float timer = 7f;
    public Text timerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            timerText.text = (timer).ToString("0");
        }
        if (timer < 0)
        {
            timer = 7f;
        }
    }
}
