using UnityEngine;
using UnityEngine.InputSystem.Android;

public class RandomSpawn : MonoBehaviour
{

    private float timer;
    private int pause =5;
    public GameObject fish1;
    public GameObject fish2;
    public GameObject fish3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        int spawnRandom = Random.Range(1, 4);
        timer = timer + Time.deltaTime;
        if (timer>= pause)
        {
            if (spawnRandom == 1)
            {
                Instantiate(fish1, new Vector3(transform.position.x, transform.position.y, -4.9f), Quaternion.Euler(0, 0, 90));
                timer = 0;
            }
            if (spawnRandom == 2)
            {
                Instantiate(fish2, new Vector3(transform.position.x, transform.position.y, -4.9f), Quaternion.Euler(0, 0, 90));
                timer = 0;
            }
            if (spawnRandom == 3)
            {
                Instantiate(fish3, new Vector3(transform.position.x, transform.position.y, -4.9f), Quaternion.Euler(0, 0, 90));
                timer = 0;
            }
        }
    }
}
