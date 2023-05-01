using UnityEngine;

public class Cell : MonoBehaviour
{
    //アイテムボックスの縦配列と横配列のインデックスを格納するクラス
    public int vertical;
    public int horizontal;
    public Cell(int vertical, int horizontal)
    {
        this.vertical = vertical;
        this.horizontal = horizontal;
    }
}
