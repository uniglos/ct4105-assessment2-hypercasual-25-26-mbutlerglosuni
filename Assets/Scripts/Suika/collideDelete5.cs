using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject scoreManager;
    private ScoreCount scoreCount;

    

    private void Awake()
    {
        scoreManager = GameObject.Find("Score");
        scoreCount = scoreManager.GetComponent<ScoreCount>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if( collision.gameObject.tag == "fish5")
        {
            scoreCount.increase5 = true;
            
            Destroy(gameObject);
        }
    }
}
