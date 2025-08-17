using TMPro; 
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private LayerMask _obstacleLayer;
    [SerializeField] private TextMeshProUGUI _scoreText; 
    private int _score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
            UpdateScore(); 
    }

    private void UpdateScore()
    {
        Debug.Log("Score erhöhen!"); 
        //erhöhe den Score um 1
        //zeige den Aktualiserten Score an.
        //Tipp: google nach TextmeshPro text aktualliseren 
    }
}
