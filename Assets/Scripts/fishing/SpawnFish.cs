using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using System.Collections;

public class SpawnFish : MonoBehaviour
{
    private float width;
    private float height;
    public GameObject fish1;
    public GameObject fish2;
    public GameObject fish3;
    public GameObject fish4;
    public GameObject fish5;
    public float timer = 0f;
    public int counter;
    public int randomfish;
    public Vector3 randomSpace;

    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer >= 10f && counter <= 10)
        {
            SpawnNewFish();
            timer = 0f;
            Debug.Log("spawned");
        }
        
    }
    public void SpawnNewFish()
    {
        randomfish = Random.Range(0, 15);
        Vector3 randomSpace = new Vector3(Random.Range(-2.6f, 2.6f), Random.Range(-1, 0.5f), 1.2f);
        if (randomfish == 0)
        {
            Instantiate(fish5, randomSpace, Quaternion.Euler(0, 0, -90));
            counter += 1;
        }
        if (randomfish > 0 && randomfish <= 2)
        {
            Instantiate(fish4, randomSpace, Quaternion.Euler(0, 0, -90));
            counter += 1;
        }
        if (randomfish > 2 && randomfish <= 5)
        {
            Instantiate(fish3, randomSpace, Quaternion.Euler(0, 0, -90));
            counter += 1;
        }
        if (randomfish > 5 && randomfish <= 9)
        {
            Instantiate(fish2, randomSpace, Quaternion.Euler(0, 0, -90));
            counter += 1;
        }
        if (randomfish > 9)
        {
            Instantiate(fish1, randomSpace, Quaternion.Euler(0, 0, -90));
            counter += 1;
        }
    }
}
