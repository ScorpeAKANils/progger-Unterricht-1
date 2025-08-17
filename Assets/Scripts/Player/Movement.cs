using System.Collections;
using UnityEngine;

public enum PActions
{
    None = -1,
    Jump,
    Crouch
}

public class Movement : MonoBehaviour
{
    [SerializeField] private float _jumpStrenght = 5f;
    [SerializeField, Range(0, 1)] private float _crouchDuration = 0.33f;

    private Rigidbody2D _rb;
    private InputCollector _inputCollector;
    private CollisionHandler _collisionHandler; 
    private PActions _desiredAction = PActions.None;
    private bool _isCrouched = false; 

    void Awake()
    {
        _rb = this.GetComponent<Rigidbody2D>();
        _inputCollector = this.GetComponent<InputCollector>();
        _collisionHandler = this.GetComponent<CollisionHandler>();
    }

    void Update()
    {
        _desiredAction = _inputCollector.LastAction;

        switch (_desiredAction)
        {
            case PActions.Jump:
                Jump(); 
                break;
            case PActions.Crouch:
                Crouch(); 
                break;
            default:
                break; 
        }
    }

    private void Jump()
    {
        Debug.Log("möchte springen...");
        //nutze die Funktion "GroundCheck" aus dem Collision Handler um in einer Fallabfrage zu überprüfen ob der Spieler grounded ist
        //wenn der Spieler grounded ist, adde eine Force nach oben als Impulse, damit der Spieler springt. Wenn der Spieler nicht grounded ist, passiert nichts. 
    }

    private void Crouch()
    {
        Debug.Log("möchte crouchen...");
        //wenn der Spieler nicht crouched ist, soll der Spieler sich crouchen können.
        if (false == true)
        {
            StartCoroutine(CrouchYield()); 
        }
    }

    private IEnumerator CrouchYield()
    {
        _isCrouched = true; 
        Vector3 baseScale = this.transform.localScale; 
        //halbiere die größe des Spielers
        //nutze den RigidBody um einen Impuls nach unten hinzuzufügen 
        yield return new WaitForSeconds(_crouchDuration);
        transform.localScale = baseScale; 
        _isCrouched = false; 
    }
}