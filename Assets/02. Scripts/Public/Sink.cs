using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour, IInteractable
{
    private bool isTap = false; // �������� ���� ���� �Ǻ� ����

    public void Interact()
    {
        if (isTap) // ���������� ����뿡 �����Ѵٸ�
        {
            // �� Ʋ��
            print("Water");
        }
        else // ���������� ���ٸ�
        {
            // ���� Ʋ�� ����
            print("No Tap");
        }
    }
}