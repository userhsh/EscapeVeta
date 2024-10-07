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

    //public void TurnOnWater(Collider _collider)
    //{
    //    if (_collider.CompareTag("HOLE"))
    //    {
    //        Debug.Log("�������� ����");
    //        transform.localPosition = new Vector3(-0.014f, 1.158f, 0.404f);
    //    }
    //    if (_collider.CompareTag("PLAYER"))
    //    {
    //        Debug.Log("�������� Ʋ��");
    //        animator.SetBool("isTurnOn", true);
    //    }
    //}

    public void TurnOnWater()
    {
        Debug.Log("�������� Ʋ��");
        animator.SetBool("isTurnOn", true);
    }
}
