using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float speed = 7.0f;
    public float deadZoneX = -45.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < deadZoneX)
        {
            Destroy(gameObject);
        }
    }
}
