using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;   

    void Start()
    {
        Debug.Log("=== Spawning 10 Street Lamps now ===");

        float spacing = 0.85f;   

        for (int i = 0; i < 10; i++)
        {
            float x = -1f + (i - 4.5f) * spacing;   
            Vector3 spawnPosition = new Vector3(x, 0.2f, -5f);   
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}