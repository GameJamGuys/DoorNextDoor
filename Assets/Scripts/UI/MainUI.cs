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
                    mainPanel.SetActive(true);
                    state = UIstate.Pause;
                    break;
                case UIstate.Pause:
                case UIstate.Setting:
                    state = UIstate.Game;
                    UnPause();
                    break;
            }
        }
    }

    public void UnPause()
    {
        settPanel.SetActive(false);
        mainPanel.SetActive(false);
    }
}
