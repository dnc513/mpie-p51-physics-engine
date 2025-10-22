using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float force;
    public float speed = 25.0f;
    public float horizontalSpeed = 25.0f;

    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody> ();
    }

    void Update ()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float movement = horizontalInput * horizontalSpeed * Time.deltaTime;
        Transform t = gameObject.transform;
        t.Translate (-movement, 0.0f, 0.0f);
      
    }

    void AddForce()
    {
        Rigidbody rb = GetComponent<Rigidbody> ();
        rb.AddForce(new Vector3 (5.0f, 5.0f, 0.0f));

    }

    void FixedUpdate() 
    {
        if (Input.GetKeyDown("space")) {
            AddForce();
        }
        if (Input.GetKeyDown("W")) {
            
        }
    }
}

