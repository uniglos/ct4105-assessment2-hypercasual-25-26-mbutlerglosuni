using UnityEngine;

public class collideDelete3 : MonoBehaviour
{
    public bool doNothing;
    public GameObject fish4;

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
        if (collision.gameObject.tag == "fish3")
        {
            
            if (doNothing) return;

            //destroys the first
            
            collision.gameObject.GetComponent<collideDelete3>().doNothing = true;
            
            Destroy(collision.gameObject);

            scoreCount.increase3 = true;

            //destroys the second and spawns a new fish
            Instantiate(fish4, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, -90));
            

            Destroy(gameObject);

        }
        audio.Play();
    }
}
