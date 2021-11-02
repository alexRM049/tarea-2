using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamescript : MonoBehaviour
{
    int SpriteIndex = -1;

    public int PlayerTurn()
    {
        
        SpriteIndex++;
        return SpriteIndex % 2;
    }
}
