using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PairingSymbol : MonoBehaviour
{
    public Sprite badSymbol;
    public Sprite normalSymbol;
    public Sprite goodSymbol;

    public SpriteRenderer rend;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }
}
