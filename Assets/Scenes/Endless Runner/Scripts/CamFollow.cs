using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4;
  
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
    }
}
