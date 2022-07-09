using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDoor : MonoBehaviour
{
    Button button;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        anim = GetComponent<Animator>();

       // button.OnClick.AddListner(Open);
    }

    public void Open()
    {
        anim.Play("Open");
       // Loader.NextLevel();
    }


}
