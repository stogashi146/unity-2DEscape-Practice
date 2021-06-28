using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
 
    public void OnThis()
    {

        bool hasItem = ItemBox.instance.CanUseItem(Item.ItemType.Hammer);
        if (hasItem == true)
        {
            ItemBox.instance.UseItem(Item.ItemType.Hammer);
            gameObject. SetActive(false);
            AudioManager.instance.playSE(AudioManager.SE.Slime);
        }

    }


}
