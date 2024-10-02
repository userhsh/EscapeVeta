using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillow : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        // Resources �������� õ ������ ��������
        GameObject fabic = Resources.Load("Prefabs/PillowFabic") as GameObject;

        // õ ����
        Instantiate(fabic, this.transform.position, fabic.transform.rotation);

        // ���� ����
        Destroy(gameObject);
    }
}