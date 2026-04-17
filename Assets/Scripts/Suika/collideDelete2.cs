using UnityEngine;
using UnityEngine.InputSystem.XR;

public class collideDelete2 : MonoBehaviour
{

    

    public bool doNothing;
    public GameObject fish3;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fish2")
        {
            if (doNothing) return;

            //destroys the first
            collision.gameObject.GetComponent<collideDelete2>().doNothing = true;
            Destroy(collision.gameObject);

            //destroys the second and spawns a new fish
            Instantiate(fish3, new Vector3(transform.position.x,transform.position.y, transform.position.z), Quaternion.Euler(0,0,-90));
            
            Destroy(gameObject);

        }
    }
}
