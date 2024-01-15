using System.Collections;
using UnityEngine;

public class PikeSpawner : MonoBehaviour
{
    public GameObject pikePrefab; // assign your meteor prefab in the inspector
    public float spawnRateFor3sMin = 1f; // Pikes per second
    public float spawnRateFor3sMax = 3f; // Pikes per second


    private void Start()
    {
        StartCoroutine(SpawnPikes());
    }

    private IEnumerator SpawnPikes()
    {
        while (true)
        {
            Instantiate(pikePrefab, GenerateRandomPosition(), Quaternion.identity);
            yield return new WaitForSeconds(3f/ Random.Range(spawnRateFor3sMin, spawnRateFor3sMax));
        }
    }

    private Vector2 GenerateRandomPosition()
    {

        return new Vector2(10, 0);
    }
}