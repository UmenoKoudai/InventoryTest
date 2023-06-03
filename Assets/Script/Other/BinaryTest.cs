using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;

public class BinaryTest : MonoBehaviour
{
    [Serializable]
    public class SaveData
    {
        public int itemID;
        public string itemName;
        public int[] getItems;
        public SaveData(int itemID, string itemName, int[] getItems)
        {
            this.itemID = itemID;
            this.itemName = itemName;
            this.getItems = getItems;
        }
    }
    SaveData data = new SaveData(1, "りんご", new int[] { 1, 2, 3, 4, 5 });
    void Start()
    {
        data = OnLoad(data);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            data.itemID += 1;
            data.itemName = $"アイテム{data.itemID}";
            int index = UnityEngine.Random.Range(0, data.getItems.Length);
            data.getItems[index] += 2;
            OnSave(data);
        }
    }
    public void TestLog()
    {
        Debug.Log($"アイテムID = {data.itemID}");
        Debug.Log($"アイテム名 = {data.itemName}");
        for (int i = 0; i < data.getItems.Length; i++)
        {
            Debug.Log($"取得アイテム = {data.getItems[i]}");
        }
    }
    public void OnSave(SaveData data)
    {
        using (FileStream fs = new FileStream(Application.persistentDataPath + "/save.bytes", FileMode.Create, FileAccess.Write))
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, data);
        }
    }

    public SaveData OnLoad(SaveData data)
    {
        try
        {
            using (FileStream fs = new FileStream(Application.persistentDataPath + "/save.bytes", FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return data = bf.Deserialize(fs) as SaveData;
            }
        }
        catch
        {
            return data;
        }
    }
}
