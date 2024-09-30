using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorgueBoxDoor : MonoBehaviour
{
    Animator animator;
    bool DoorOpen = false;

    private void Awake()
    {
        this.animator = GetComponent<Animator>();
        this.animator.SetBool("DoorOpen", false);     
    }

    public void MogueBoxDoorOpenClose() //��ü������ �ִϸ��̼����� ����ݴ� �޼���
    {
        if (DoorOpen == false)
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
