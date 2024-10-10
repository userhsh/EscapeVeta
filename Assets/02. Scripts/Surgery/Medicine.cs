using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicine : MonoBehaviour, IInteractable
{
    public MedicineFabric medicineFabric;

    private void Awake()
    {
        medicineFabric.gameObject.SetActive(false);
    }

    public void Interact()
    {
        // �� ���� õ ����
        medicineFabric.gameObject.SetActive(true);
        // õ ����
        Destroy(medicineFabric.gameObject);
        // ��ǰ ����
        Destroy(gameObject);
    }
}