using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorgueDoors : MonoBehaviour
{
    Animator animator;
    public bool MorgueDoorLock = true; //�� ��� Ȱ��
    bool DoorOpen = false;

    private void Awake()
    {
        this.animator = GetComponent<Animator>();
        this.animator.SetBool("DoorOpen", false); //�ִϸ��̼� �Ķ���� DoorOpen
    }

    public void MorgueDoorsOpenClose() //��ǰ���ݹ� �ִϸ��̼����� ����ݴ� �޼���
    {
        if (MorgueDoorLock == false) //����� Ǯ���� ��
        {
            if (DoorOpen == false) //�� ������ �� ��ȣ�ۿ� ��
            {
                //�� ���� �ִϸ��̼� ����
                this.animator.SetBool("DoorOpen", true);
                DoorOpen = true;
            }
            else //�� ������ �� ��ȣ�ۿ� ��
            {
                //�� �ݱ� �ִϸ��̼� ����
                this.animator.SetBool("DoorOpen", false);
                DoorOpen = false;
            }
        }

    }

    public void Animationing()
    {
        this.gameObject.GetComponent<Collider>().enabled = false;
    }
    public void AnimationEnd()
    {
        this.gameObject.GetComponent<Collider>().enabled = true;
    }
}
