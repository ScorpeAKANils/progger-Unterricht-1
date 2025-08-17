using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ernestolerntcoden : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
        int B = 9; // muss ganze Zahlen sein
        int D = 10;
        B += D; // kurzform für B = B + D, Wissen das Ergebinis (B) irgendetwas +9 ist und addieren Wert D (+10) 
        Debug.Log(B); // Gibt Aussagen in der Console an, nicht im Bild

        float x = 5.5f; // für Kommerzahlen
        double y = 5.5; // auch für Kommerzahlen, aber in der Rundung genauer
        y += x;
        Debug.Log(y);

        bool boolischerWert = false; // Sagt aus, ob eine Aussage wahr oder Falsch ist
        bool boolischerWertZwei = true;


        int A = 9;
        int E = 9;

        bool F = A != E;
        Debug.Log(!F);// Aussage wird als True rauskommen, da es eine doppelte Verneinung ist

        // ist genau gleich: ==; größer gleich: >=; kleiner gleich: <=; ist ungleich: !=; ist kleiner: <; ist größer: >
        // ! ist immer Verneinung


        string ditIsNText = "Was geht ab?";
       Debug.Log(ditIsNText);

        string dieZweite = " Alles was Beine hat.";
        string kombiniert = ditIsNText + dieZweite; // Zweiter Text muss mit Leerzeichen beginn, damit dieser in Console angezeigt wird
        Debug.Log(kombiniert);

        int Z = Addition(10, 35);
        Debug.Log(Z);
    }

    private int Addition(int a, int b)
    {
        return a + b;
    }


    // Update is called once per frame
    private void Update()
    {
        
    }
}
