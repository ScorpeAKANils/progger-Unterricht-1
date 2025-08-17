using UnityEngine;

public class InputCollector : MonoBehaviour
{
    public PActions LastAction { get; private set; } = PActions.None;

    private void Update()
    {
        CollectInput(); 
    }
    private void CollectInput()
    {
        //suche in den Docs von Unity nach einer Methode um Input auszulesen und passe die fall Abfragen so an, dass wenn 'W' gedrückt wird der Spieler springt und wenn S gedrückt wird springt
        if (true == false)
        {
            Debug.Log("W wurde gedrückt. Nice."); 
            LastAction = PActions.Jump;
        }
        else if (false == true)
        {
            Debug.Log("S wurde gedrückt. Nice.");
            LastAction = PActions.Crouch;
        }
        else
            LastAction = PActions.None; 
    }
}
