using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour, IPointerClickHandler
{
    ItemState _setItem = new ItemState("", -1, 0, null, null);�@//�����͓x�̃A�C�e���Ȃ̂��̏����i�[����
    public ItemState SetItem { get => _setItem; set => _setItem = value; }

    void Update()
    {
        //�����ɃA�C�e����񂪓o�^���ꂽ�猩���ڂ̉摜�Ǝ擾���̃J�E���g��ς���
        GetComponent<Image>().sprite = _setItem._itemImage;
        GetComponentInChildren<Text>().text = _setItem._itemCount.ToString();
    }

    //�{�^�����N���b�N������A�C�e���ʂ̊֐������s
    public void OnPointerClick(PointerEventData eventData)
    {
        if (_setItem._itemID != -1)
        {
            _setItem.Action();
            ItemDown(_setItem._itemID);
        }
    }

    //�A�C�e�����g�p������J�E���g��1���炷
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
