using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public GameObject[] Boxs;

    //インスタンス化して、このクラスを他のスクリプトからでもアクセスできるようにする。
    public static ItemBox instance;
    public void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        //ゲーム開始時にアイテムボックス欄を非表示にする
        for(int i = 0; i < Boxs.Length; i++)
        {
            Boxs[i].SetActive(false);
        }
    }

    public void SetItem(Item.ItemType item)
    {
        int index = (int)item;
        Boxs[index].SetActive(true);
        AudioManager.instance.playSE(AudioManager.SE.Get);
    }

    public void UseItem(Item.ItemType item)
    {
        int index = (int)item;
        Boxs[index].SetActive(false);

    }
    public bool CanUseItem(Item.ItemType item)
    {
        int index = (int)item;
        if (Boxs[index].activeSelf==true)
        {
            return true;
        }
        return false;
    }


}
