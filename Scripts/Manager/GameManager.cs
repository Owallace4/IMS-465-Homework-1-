using UnityEngine;
using UnityEngine.SceneManagement; 
public class GameManager : MonoBehaviour
{
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;

    public int rows;
    public int columns;
    public int spacing; 

    [SerializeField]
    private Transform pieces = null;

    [SerializeField]
    private GameObject piecePrefab = null;

    [SerializeField]
    private GameObject Ball = null; 

    [SerializeField]
    private EdgeCollider2D border;

    public int count; 

    private void Start()
    {
        

    }

    void Update()
    {
        Reset(); 
    }

    void Reset()
    {
        GameObject[] pieces;
        pieces = GameObject.FindGameObjectsWithTag("Piece");
        count = pieces.Length;
        if(count == 0)
        {
            SceneManager.LoadScene("SampleScene"); 
        }
        // resets the game if you destroy all the pieces 
    }

    //TODO
    //Using const data defined above "Instantiate" new pieces to fill the view with
}
