using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject amongus;
        Instantiate(amongus, new Vector3(10, 10, 10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
