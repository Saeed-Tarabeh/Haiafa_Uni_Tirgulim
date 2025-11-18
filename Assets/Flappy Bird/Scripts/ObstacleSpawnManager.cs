using UnityEngine;

public class ObstacleSpawnManager : MonoBehaviour
{
    [SerializeField] float spawnInterval = 2f;
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] float minY = 1f;
    [SerializeField] float maxY = 5f;

    private float timeSinceLastSpawn = 0f;
    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnObstacle();
            timeSinceLastSpawn = 0f;
        }
        
        void SpawnObstacle()
        {
            Instantiate(obstaclePrefab,
            transform.position + new Vector3(0, Random.Range(minY, maxY)),
            Quaternion.identity);
        }
    }
}
