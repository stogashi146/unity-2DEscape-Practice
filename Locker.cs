using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
    public void Open()
    {
        AudioManager.instance.playSE(AudioManager.SE.Doar);
        gameObject.SetActive(false);
    }

}
