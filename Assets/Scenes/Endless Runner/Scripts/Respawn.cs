using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    List<CoinWork> coins;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coins = FindObjectsByType<CoinWork>(FindObjectsSortMode.None).ToList();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector3(1, 1, -7);
        }

        foreach (CoinWork item in coins)
        {
            item.gameObject.SetActive(true);
            item.collectedCoin = false;
        }
    }
}
