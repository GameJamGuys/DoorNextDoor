using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public KeyCode pauseKey = KeyCode.Escape;
    public GameObject mainPanel;
    public GameObject settPanel;

    public static MainUI Instance { get; private set; }
    enum UIstate { Game, Pause, Setting}
    UIstate state;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        state = UIstate.Game;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            switch (state)
            {
                case UIstate.Game:
                    Pause();
                    break;
                case UIstate.Pause:
                case UIstate.Setting:
                    UnPause();
                    break;
            }
        }
    }

    public void Pause()
    {
        AudioManager.Instance.PlaySound("Button");
        mainPanel.SetActive(true);
        state = UIstate.Pause;
    }

    public void UnPause()
    {
        AudioManager.Instance.PlaySound("Button");
        state = UIstate.Game;
        settPanel.SetActive(false);
        mainPanel.SetActive(false);
    }
}
