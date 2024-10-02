using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalpel : MonoBehaviour, IUseable
{
    // ������ ���� ���� ����
    Pillow pillow = null;
    // ������ ���� ���� ����
    //Doll doll = null;

    // ����� ��
    private void OnTriggerEnter(Collider other)
    {
        Use(other);
    }

    public void GetItem(Transform _pos)
    {
        transform.SetParent(_pos);
        transform.position = _pos.position;
    }

    public void Use(Collider _collider)
    {
        // _collider�� ���� ��������
        pillow = _collider.gameObject.GetComponent<Pillow>();
        // ������ �� �������� ���
        if (pillow == null)
        {
            // �޼��� ����������
            return;
        }
        // ������ ���� ��� Interact ����
        pillow?.Interact();

        // _collider�� ���� ��������
        //doll = _collider.gameObject.GetComponent<Doll>();
        // ������ �� �������� ���
        //if (doll == null)
        //{
        //    // �޼��� ����������
        //    return;
        //}
        // ������ ���� ��� Interact ����
        //doll?.Interact();
    }
}