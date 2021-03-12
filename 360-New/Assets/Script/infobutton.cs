using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infobutton : MonoBehaviour
{
    public GameObject infopannel;
    public bool isActive = false;
    public void ShowInfo(){
        if (!isActive){
            infopannel.SetActive(true);
            isActive = true;
        }else
        {infopannel.SetActive(false);
        isActive = false;}
    }

}
