using UnityEngine;

public class collideDelete4 : MonoBehaviour
{
    public bool doNothing;
    public GameObject fish5;

    public GameObject scoreManager;
    private ScoreCount scoreCount;

    

    private void Awake()
    {
        scoreManager = GameObject.Find("Score");
        scoreCount = scoreManager.GetComponent<ScoreCount>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fish4")
        {
            
            if (doNothing) return;

            //destroys the first
            
            collision.gameObject.GetComponent<collideDelete4>().doNothing = true;
            
            Destroy(collision.gameObject);

            scoreCount.increase4 = true;

            //destroys the second and spawns a new fish
            Instantiate(fish5, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, -90));
            

            Destroy(gameObject);

        }
    }
}
