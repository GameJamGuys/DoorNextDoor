using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRoll : MonoBehaviour
{
    public float waitTime = 5f;
    public float rollSpeed = 5f;

    public float stopDistance = 100f;

    bool isMove;
    void Start()
    {
        isMove = false;
        StartCoroutine(WaitAndMove(waitTime));
    }

    void Update()
    {
        if (isMove)
        {
            transform.Translate(Vector3.up * rollSpeed * Time.deltaTime);
        }

        if (GetComponent<RectTransform>().position.y >= stopDistance) isMove = false;
    }

    IEnumerator WaitAndMove(float time)
    {
        yield return new WaitForSeconds(time);
        isMove = true;
    }
}
