using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteLogic : MonoBehaviour
{
    public int noteIndex;
    [TextArea]
    public string noteText;
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OpenNote);
    }

    void OpenNote()
    {
        MainUI.Instance.state = MainUI.UIstate.Note;
        MainUI.Instance.OpenNote(noteIndex, noteText);
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
