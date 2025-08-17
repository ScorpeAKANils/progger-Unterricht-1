using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 15f; 

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = this.GetComponent<Rigidbody2D>(); 
    }
    void Update()
    {
        //passe den code so an, dass der das Obstacle sich mit "speed" nach links bewegt. 
        _rb.AddForce(Vector2.zero * 0, ForceMode2D.Force); 
    }
}
