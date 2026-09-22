using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float flapStrength = 10;
    public LogicScript logic;
    public bool BirdIsAlive = true;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && BirdIsAlive)
        {
            rigidbody.linearVelocity = Vector3.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        BirdIsAlive = false;
    }
}
