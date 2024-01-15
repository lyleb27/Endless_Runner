using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform playerTransform;
    public float obstacleSpeed = 5f;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0f, spawnInterval);
    }

    void SpawnObstacle()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), 10f, 0f); // Ajustez les valeurs selon vos besoins
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);

        // Définir le parent pour garder la scène organisée
        obstacle.transform.parent = transform;
    }

    void Update()
    {
        MoveObstacles();
    }

    void MoveObstacles()
    {
        foreach (Transform obstacle in transform)
        {
            obstacle.Translate(Vector3.down * obstacleSpeed * Time.deltaTime);

            if (obstacle.position.y < -10f)
            {
                Destroy(obstacle.gameObject);
            }
        }
    }
}
