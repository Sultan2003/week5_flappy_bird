using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;  // How often to spawn pipes
    public float heightOffset = 2f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        float randomHeight = Random.Range(-heightOffset, heightOffset);
        Instantiate(pipePrefab, new Vector3(10f, randomHeight, 0), Quaternion.identity);
    }
}
