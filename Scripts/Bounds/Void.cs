using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Void : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Ball"))
        {
            Destroy(collider.gameObject);
            
            SceneManager.LoadScene("SampleScene");
            // destroys the object that collides with it then resets the game 
        }
    }
}
