using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public int vertical;
    public int horizontal;
    public Cell(int vertical, int horizontal)
    {
        this.vertical = vertical;
        this.horizontal = horizontal;
    }
}
