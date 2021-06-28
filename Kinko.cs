using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinko : MonoBehaviour
{
    public GameObject openKinko;
    public void OnThis()
    {

        bool hasItem = ItemBox.instance.CanUseItem(Item.ItemType.Key);
            if(hasItem == true)
        {
            AudioManager.instance.playSE(AudioManager.SE.Doar);
            ItemBox.instance.UseItem(Item.ItemType.Key);
            openKinko.SetActive(true);
        }

    }
        

    
}
