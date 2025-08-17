using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSpriteByScreenSize : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private float _hightOffset = 1; 

    // Start is called before the first frame update
    void Start()
    {
        Resize(); 
    }

    public void Resize()
    {
        Vector2 spriteSize = _renderer.bounds.size;
        Vector3 adjustedPos = Camera.main.transform.position;

        float screenHeight = Camera.main.orthographicSize * 2f;
        float screenWidth = spriteSize.y / Screen.height * Screen.width;

        transform.localScale = new Vector3(screenWidth / spriteSize.x, screenHeight/spriteSize.y, transform.localScale.z); 
        adjustedPos.z = 0;
        adjustedPos.y += _hightOffset; 
        transform.position = adjustedPos; 
    }
}
