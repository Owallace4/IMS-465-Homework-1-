using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody = null;

    [SerializeField]
    private float speed = 10.0f;

    private Vector3 currentDirection = Vector3.zero; 

    //TODO: Add code to move ball along with code to delete pieces upon colliding with one
    //Ball should only move once its been launched

    private void Awake()
    {
        currentDirection = new Vector3(0, Random.Range(0f,-5f), 0).normalized; 
        // sets the initial speed and direction moved. 
    }

    private void Update()
    {
        var newDelta = currentDirection * Time.deltaTime * speed;
        rigidBody.MovePosition(transform.position + newDelta); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision occured");
        currentDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal); 
        // Checks collision and reflects the colliding object
        if(collision.gameObject.tag == "Piece")
        {
            Destroy(collision.gameObject);
            // if it collides with a brick it destroys it
        }
    }

}
