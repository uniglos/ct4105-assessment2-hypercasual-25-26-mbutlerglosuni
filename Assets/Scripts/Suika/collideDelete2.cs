using UnityEngine;

public class collideDelete2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fish2")
        {
            Debug.Log("collided");
            Destroy(gameObject);
        }
    }
}
