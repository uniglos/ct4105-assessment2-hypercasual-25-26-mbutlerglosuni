using UnityEngine;
using UnityEngine.InputSystem.Android;
using System.Collections;

public class MoveSideToSide : MonoBehaviour
{

    private Vector3 position;
    private float width;
    private float height;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        width = (float)Screen.width/3f ;
        
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                pos.x = ((pos.x- width)/width)-3f;
                
                position = new Vector3(pos.x, transform.position.y, transform.position.z);

                transform.position = position;
            }
        }
    }
}
