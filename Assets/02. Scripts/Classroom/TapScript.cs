using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TapScript : MonoBehaviour
{
    bool isTurnOn = false;
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void TurnOnWater()
    {
        Debug.Log("�������� Ʋ��");
        animator.SetBool("isTurnOn", true);
    }
}
