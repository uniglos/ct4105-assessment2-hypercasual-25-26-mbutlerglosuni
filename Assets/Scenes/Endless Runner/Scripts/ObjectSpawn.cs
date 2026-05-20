using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject amongus;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Instantiate(amongus, new Vector3(10, 10, 10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
