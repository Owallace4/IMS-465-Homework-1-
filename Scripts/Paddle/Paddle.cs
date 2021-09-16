using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    [SerializeField]
    private Ball ballPrefab;

    public bool instBall; 
    void Start()
    {
        
    }

    void Update()
    {
     if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World); 
        }   
     if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World); 
        }
        // Move paddle left and right using keyboard keys, mapping is up to you

        var xPosition = Mathf.Clamp(transform.position.x, -10.04236f, 9.976992f);
        transform.position = new Vector3(xPosition, transform.position.y , transform.position.z);
        // paddle bounds 

        Vector3 paddlePosition = this.gameObject.transform.position;
        Vector3 ballPosition = new Vector3(paddlePosition.x, paddlePosition.y + 0.4f, 0);

      
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(ballPrefab, ballPosition, Quaternion.identity);

                instBall = true;
            }
        // Launch the ball 
    }

    //TODO
    // Move paddle left and right using keyboard keys, mapping is up to you
    // Paddle should be able to launch the ball upon space bar being pressed
    // A launched ball will then bounce around, changing its direction upon any collision
}
