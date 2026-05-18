using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using System.Collections;

public class FishMove : MonoBehaviour
{
    public Vector3 goHere;
    public float timer = 0f;
    public bool startTiming=false;
    public float speed=5;
    public int randomDespawn;
    public GameObject spawnmanager;
    public SpawnFish counter;

    private void Awake()
    {
        //Vector3 goHere = new Vector3(Random.Range(-2.6f, 2.6f), Random.Range(-1f, 0.5f), 1.2f);
        goHere.x = Random.Range(-2.6f, 2.6f);
        goHere.y = Random.Range(-1f, 0.5f);
        goHere.z = 1.2f;
        startTiming = true;
        spawnmanager = GameObject.Find("SpawnManager");
        counter = spawnmanager.GetComponent<SpawnFish>();
        randomDespawn = Random.Range(9, 16); ;
    //moveAround();
}

    // Update is called once per frame
    void Update()
    {
        if (startTiming)
        {
            timer += Time.deltaTime;
        }
        if (timer >= randomDespawn)
        {
            
            counter.counter -= 1;
            Destroy(gameObject);
        }
        moveAround();
        if (transform.position == goHere)
        {
            goHere.x = Random.Range(-2.6f, 2.6f);
            goHere.y = Random.Range(-1f, 0.5f);
        }
    }
    public void moveAround()
    {
        

        transform.position = Vector3.MoveTowards(transform.position, goHere, speed * Time.deltaTime);
        if (transform.position.x > goHere.x)
        {
            transform.rotation = Quaternion.Euler(0, 180,-90);
        }
        if (transform.position.x < goHere.x)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }


    }
}
