using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forwardForce = 1500f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game started");

        rigidbody.useGravity = true;
    }

    // Update is called once per frame
    // We are using FixedUpdate rather than Update cuz it helps Unity for messing with physics
    void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rigidbody.AddForce(sidewaysForce * -1 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rigidbody.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
