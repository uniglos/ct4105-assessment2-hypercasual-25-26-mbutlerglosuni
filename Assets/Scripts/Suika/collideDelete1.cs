using UnityEngine;

public class collideDelete1 : MonoBehaviour
{
    public bool doNothing;
    public GameObject fish2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fish1")
        {
            if (doNothing) return;

            //destroys the first
            collision.gameObject.GetComponent<collideDelete1>().doNothing = true;
            Destroy(collision.gameObject);

            //destroys the second and spawns a new fish
            Instantiate(fish2, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, -90));

            Destroy(gameObject);

        }
    }
}
