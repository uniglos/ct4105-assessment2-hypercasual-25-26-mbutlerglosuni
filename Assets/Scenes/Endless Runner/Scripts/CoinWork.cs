using System.Collections;
using UnityEngine;

public class CoinWork : MonoBehaviour
{
    [SerializeField] public bool collectedCoin;
    void Update()
    {
        transform.Rotate(0, 2, 0, Space.World);
        if (collectedCoin == true)
        {
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        collectedCoin = true;
        StatControl.coinCount += 1;
        this.gameObject.GetComponent<Animator>().Play("Shrink");
        StartCoroutine(DeleteCoin());
    }

    IEnumerator DeleteCoin()
    {
        
        this.gameObject.SetActive(false);
        yield return null;
    }
}

