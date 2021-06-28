using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyaji : MonoBehaviour
{
    public GameObject sakeOyaji;
    public GameObject hintOyaji;



    public void OnThis()
    {
        //酒を持っていたら、親父を消す
        bool hasSake = ItemBox.instance.CanUseItem(Item.ItemType.Sake);
        
        if (hasSake == true)
        {
            ItemBox.instance.UseItem(Item.ItemType.Sake);
            sakeOyaji.SetActive(true);
            AudioManager.instance.playSE(AudioManager.SE.Inshu);
            Invoke("HintOyaji", 2);
            
        }

    }

    void HintOyaji()
    {
        sakeOyaji.SetActive(false);
        hintOyaji.SetActive(true);
    }

}
