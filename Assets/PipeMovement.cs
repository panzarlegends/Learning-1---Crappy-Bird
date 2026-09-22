using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public float deadZone = -18;
    void Awake()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);

        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
            Debug.Log("Pipe deleted");
        }
    }
}
