using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using System.Collections;

public class FishMove : MonoBehaviour
{
    public Vector3 goHere;
    public float timer = 0f;
    public bool startTiming=false;
    public int speed=5;

    private void Awake()
    {
        Vector3 goHere = new Vector3(Random.Range(-2.6f, 2.6f), Random.Range(-1, 0.5f), 1.2f);
        startTiming = true;
        moveAround();
    }

    // Update is called once per frame
    void Update()
    {
        if (startTiming)
        {
            timer += Time.deltaTime;
        }
        if (timer>= 10f)
        {
            Destroy(gameObject);
        }
    }
    public void moveAround()
    {
        
        while (transform.position != goHere)
        {
            //float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, goHere, 0);
        }
        if (transform.position == goHere)
        {
            Vector3 goHere = new Vector3(Random.Range(-2.6f, 2.6f), Random.Range(-1, 0.5f), 1.2f);
        }
    }
}
