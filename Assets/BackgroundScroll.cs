using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    private float scrollSpeed = 1.5f;
    private float width = 21.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * scrollSpeed * Time.deltaTime);

        if (transform.position.x < -width)
        {
            transform.position += new Vector3(width * 2f, 0f, 0f);
        }
    }
}
