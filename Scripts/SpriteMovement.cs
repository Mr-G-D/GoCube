using UnityEngine;

public class SpriteMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float FORWARDFORCE = 4000f;
    public float SIDEFORCE = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Working");
    }


    private void FixedUpdate()
    {
        rb.AddForce(0, 0, FORWARDFORCE * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SIDEFORCE * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SIDEFORCE * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
        }

        if (rb.position.y < 0)
        {
            this.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            this.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

