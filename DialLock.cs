using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialLock : MonoBehaviour
{
    public UnityEvent ClearEvent;    
    public enum Marks
    {
        Maru,
        Sankaku,
        Hoshi,
        Daia,
    }
    Marks[] currentMarks = { Marks.Maru, Marks.Maru, Marks.Maru };
    Marks[] ClearMarks = { Marks.Hoshi, Marks.Sankaku, Marks.Hoshi };

    public Image[] buttons;
    public Sprite[] resourceMark;

    //ボタンを押す
    public void OnMarks(int position)
    {
        //画像を変更、positionには0−2が入る
        ChangeMarks(position);
        //画像を表示
        ShowMarks(position);
        if (AllClearmars() == true)
        {
            Clear();
        }
    }

    void ChangeMarks(int position)
    {
        
        
        currentMarks[position]++;
        AudioManager.instance.playSE(AudioManager.SE.Dial); 
        if (currentMarks[position] > Marks.Daia)
        {
            currentMarks[position] = Marks.Maru;
        }
    }
    void ShowMarks(int position)
    {
        //ボタンが押されたら、positionに0-2が入る
        int index = (int)currentMarks[position];
        //ボタンが押されたら、buttonsとresourceMarkに0-2を入れる
        //
        buttons[position].sprite = resourceMark[index];

    }

  

    bool AllClearmars()
    {
        if(ClearMarks[0]==currentMarks[0] &&
            ClearMarks[1] == currentMarks[1] &&
                ClearMarks[2] == currentMarks[2])
        {
            return true;
        }
        return false;
    }

    void Clear()
    {
        ClearEvent.Invoke();
        Debug.Log("ss");
    }
}
