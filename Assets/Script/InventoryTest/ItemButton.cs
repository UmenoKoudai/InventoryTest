using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour, IPointerClickHandler
{
    ItemState _setItem = new ItemState("", -1, 0, null, null);　//自分は度のアイテムなのかの情報を格納する
    public ItemState SetItem { get => _setItem; set => _setItem = value; }

    void Update()
    {
        //自分にアイテム情報が登録されたら見た目の画像と取得数のカウントを変える
        GetComponent<Image>().sprite = _setItem._itemImage;
        GetComponentInChildren<Text>().text = _setItem._itemCount.ToString();
    }

    //ボタンをクリックしたらアイテム別の関数を実行
    public void OnPointerClick(PointerEventData eventData)
    {
        if (_setItem._itemID != -1)
        {
            _setItem.Action();
            ItemDown(_setItem._itemID);
        }
    }

    //アイテムを使用したらカウントを1つ減らす
    public void ItemDown(int id)
    {
        for (int i = 0; i < Inventory.instance.ItemCount; i++)
        {
            ItemState item = Inventory.instance.ItemArray[i];
            if (item._itemCount > 1)
            {
                if (item._itemID == id)
                {
                    item._itemCount--;
                    break;
                }
                
            }
            else
            {
                Inventory.instance.ItemArray[i] = new ItemState("", -1, 0, Inventory.instance.DefaultImage, null);
                Inventory.instance.SetItem();
            }
        }
    }
}
