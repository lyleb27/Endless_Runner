using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollider : MonoBehaviour
{
     private CoinManager coinManager;
    public void Start()
    {
        coinManager = GameObject.FindWithTag("CoinManager").GetComponent<CoinManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn" || other.tag == "Player")
        {
            Destroy(gameObject);
            coinManager.IncrementCoinCount();
        }
    }
}