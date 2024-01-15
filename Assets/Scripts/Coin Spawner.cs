using System.Collections;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab; // assign your meteor prefab in the inspector

    private void Start()
    {
        StartCoroutine(SpawnCoins());
    }

    private IEnumerator SpawnCoins()
    {
        while (true)
        {
            Instantiate(coinPrefab, GenerateRandomPosition(), Quaternion.identity);
            yield return new WaitForSeconds(3.5f / 2);
        }
    }

    private Vector2 GenerateRandomPosition()
    {

        return new Vector2(10, Random.Range(0,3));
    }
}