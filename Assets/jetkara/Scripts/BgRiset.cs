using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgRiset : MonoBehaviour
{
    
    public GameObject gameObjct;
    public Sprite Sprite;
    public TextMesh scoreLabel;



    void Update()
    {
        if (scoreLabel.text == "10")
        {
            GetComponent<SpriteRenderer>().sprite = Sprite;
        }
        
    }
}
