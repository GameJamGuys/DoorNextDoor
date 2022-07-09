using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorLogic : MonoBehaviour
{
    DoorController control;
    Button button;
    Animator anim;

    void Start()
    {
        control = GetComponentInParent<DoorController>();
        button = GetComponent<Button>();
        anim = GetComponent<Animator>();

        button.onClick.AddListener(Open);
    }

    void Open()
    {
        AudioManager.Instance.PlaySound("Door");
        anim.Play("Open");
        StartCoroutine(NextDoorDelay());
    }

    IEnumerator NextDoorDelay()
    {
        yield return new WaitForSeconds(0.5f);
        AudioManager.Instance.PitchUp();
        control.NextDoor();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
