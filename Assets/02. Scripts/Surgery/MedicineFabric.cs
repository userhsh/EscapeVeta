using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineFabric : MonoBehaviour, IUseable
{
    // �ſ� ���� ���� ����
    Mirror mirror = null;

    public void GetItem(Transform _pos)
    {
        transform.SetParent(_pos);
        transform.position = _pos.position;
    }

    // ����� ��
    private void OnTriggerEnter(Collider other)
    {
        Use(other);
    }

    public void Use(Collider _collider)
    {
        // _collider�� mirror�� ��������
        mirror = _collider.gameObject.GetComponent<Mirror>();
        // mirror�� ���� ���
        if (mirror == null)
        {
            // �޼��� ����������
            return;
        }
        // mirror�� �����ϸ� Interact ����
        mirror?.Interact();
    }
}