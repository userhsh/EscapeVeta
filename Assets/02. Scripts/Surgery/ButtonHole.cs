using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHole : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        // Resources �������� ���� ���� ��ư ������ ��������
        GameObject mainShutterButton = Resources.Load("Prefabs/MainShutterButton") as GameObject;

        // ���� ���� ��ư ����
        Instantiate(mainShutterButton, this.transform.position, this.transform.rotation);

        // ��ư Ȧ ����
        Destroy(gameObject);
    }
}