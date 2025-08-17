using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private Transform _groundCheckPos;
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private float _groundDist = 0.5f;

    public bool GroundCheck()
    {
        //schau dir in der Unity Docs die Physics2D.Raycast(); funktion an, und nutze sie, um zu überprüfen ob der Spieler grounded ist oder nicht. 
        return false; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
    }
}
