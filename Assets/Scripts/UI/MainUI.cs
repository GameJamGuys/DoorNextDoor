using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainUI : MonoBehaviour
{
    public KeyCode pauseKey = KeyCode.Escape;
    public GameObject mainPanel;
    public GameObject settPanel;

    public GameObject[] notes;

    public static MainUI Instance { get; private set; }
    public enum UIstate { Game, Pause, Setting, Note}
    public UIstate state;

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
                case UIstate.Note:
                    CloseNotes();
                    break;
            }
        }
    }

    public void OpenNote(int index, string text)
    {
        notes[index].SetActive(true);
        notes[index].GetComponentInChildren<TextMeshPro>().text = text;
    }

    void CloseNotes()
    {
        foreach (GameObject note in notes) note.SetActive(false);
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
