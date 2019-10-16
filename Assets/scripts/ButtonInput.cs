using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInput : MonoBehaviour
{

    public Button[] buttons;

    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            Button btn = buttons[i].GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }
    }

    void TaskOnClick()
    {
        //Debug.Log("You have clicked the button!" + this);

    }



}
