using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject obstaclePrefab;
    public float spawnCycle = 0.5f;

    // These two numbers control exactly where each pickup spawns vertically
    public float powerupSpawnHeight = 0.5f;
    public float obstacleSpawnHeight = 0.5f;   // <-- lower this if the obstacle is still too high

    GameManager manager;
    float elapsedTime;
    bool spawnPowerup = true;

    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnCycle)
        {
            GameObject temp;
            if (spawnPowerup)
                temp = Instantiate(powerupPrefab) as GameObject;
            else
                temp = Instantiate(obstaclePrefab) as GameObject;

            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);

            // Set the correct height for whatever we're spawning
            position.y = spawnPowerup ? powerupSpawnHeight : obstacleSpawnHeight;

            temp.transform.position = position;

            Collidable col = temp.GetComponent<Collidable>();
            if (col != null)
                col.manager = manager;

            elapsedTime = 0;
            spawnPowerup = !spawnPowerup;
        }
    }
}