using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour
{
    public PlayerMovementScript movement;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("Obstacles"))
        {
            Debug.Log(collision.collider.name);

            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
