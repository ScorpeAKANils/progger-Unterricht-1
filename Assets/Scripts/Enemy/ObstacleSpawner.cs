using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _obstaclePrefs = new();
    [SerializeField] private List<Transform> _obstacleSpawnPos = new();
    [SerializeField, Range(0, 1)] private float _spawnRate = 1f; //spawnrate is in Seconds

    private int _selectedObstacle = 0;
    private float _timePassed = 0;

    void Update()
    {
        //überprüfe in der fall abfrage, ob die vergangene Zeit reicht, um ein nächstes Objekt zu spawnen. 
        if (false == true)
        {
            Spawn();
        }
        _timePassed += Time.unscaledDeltaTime; 
    }

    private void Spawn()
    {
        _timePassed = 0; 
        _selectedObstacle = Random.Range(0, 10);
        //nutze den Modolus Opertor(%) um zu bestimmen ob die random generierte Zahl gerade oder ungerade ist.
        //Wenn sie gerade ist, setze _selectedObject so, dass es auf den 1. Index der Liste zeigt, ansonnsten auf den 2. 
        GameObject obstacle = new GameObject();
        //obstacle = Instantiate(_obstaclePrefs[hier kommt der index rein], _obstacleSpawnPos[hier kommt der index rein].position, Quaternion.identity);
        Debug.Log("Habe ein obstacle gespawned"); 
        Destroy(obstacle, 3f); 
    }
}