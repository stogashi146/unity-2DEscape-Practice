using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentManager : MonoBehaviour
{
   
  
    public void OnRightArrow()
    {
        
        transform.localPosition = new Vector2(-1500,0);
    }
    public void OnLeftArrow()
    {

        transform.localPosition = new Vector2(0, 0);
    }

    public void OnLocker()
    {

        transform.localPosition = new Vector2(0, 1000);
    }
}
