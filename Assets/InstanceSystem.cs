using UnityEngine;

public class InstanceSystem<T> : MonoBehaviour where T : MonoBehaviour
{
    static T _instance;

    public static T instance
    {
        get 
        {
            //変数がnullだったらHierarchy上のオブジェクトを格納する
            if(_instance == null)
            {
                _instance = FindObjectOfType<T>();
                //それでもnullだった場合Hierarchy上に対象のスクリプトをアタッチしたオブジェクトがないのでエラー文を出す
                if(_instance == null)
                {
                    var className = typeof(T).Name;
                    Debug.LogError($"{className}がHierarchy上に存在しません");
                }
            }
            return _instance; 
        }
    }
}
