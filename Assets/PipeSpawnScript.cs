using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnInterval = 2.0f;
    private float timeSinceLastSpawn = 0.0f;
    public float heightOffset = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSinceLastSpawn >= spawnInterval)
        {
            spawnPipe();
            timeSinceLastSpawn = 0.0f;
        }
        else
        {
            timeSinceLastSpawn += Time.deltaTime;
        }
    }

    void spawnPipe()
    {
        float lowerBound = transform.position.y - heightOffset;
        float upperBound = transform.position.y + heightOffset;

        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowerBound, upperBound), 0), transform.rotation);
    }
}
