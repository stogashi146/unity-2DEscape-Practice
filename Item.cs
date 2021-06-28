using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   public enum ItemType
    {
        Sake,
        Key,
        Hammer,
    }
    public ItemType item;

    public void OnThis()
    {
        // ・非表示
        gameObject.SetActive(false);
        // TODO:アイテムBoxへ追加
        ItemBox.instance.SetItem(item);
    }
}
