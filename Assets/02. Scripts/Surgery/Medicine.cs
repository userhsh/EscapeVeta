using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicine : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        // Resources �������� �� ���� õ ������ ��������
        GameObject medicineFabic = Resources.Load("Prefabs/PillowFabic_Medicine") as GameObject;

        // õ ����
        Instantiate(medicineFabic, this.transform.position + new Vector3(0, 0.1f, 0), medicineFabic.transform.rotation);

        // ��ǰ ����
        Destroy(gameObject);
    }
}