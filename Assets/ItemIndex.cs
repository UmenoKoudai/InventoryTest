using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemIndex : MonoBehaviour
{
    public int vertical;
    public int horizontal;
    public ItemIndex(int vertical, int horizontal)
    {
        this.vertical = vertical;
        this.horizontal = horizontal;
    }
}
