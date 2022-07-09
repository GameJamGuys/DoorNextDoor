using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(PauseClick);
    }

    void PauseClick()
    {
        if(MainUI.Instance.state == MainUI.UIstate.Pause) MainUI.Instance.UnPause();
        else MainUI.Instance.Pause();
    }
}
