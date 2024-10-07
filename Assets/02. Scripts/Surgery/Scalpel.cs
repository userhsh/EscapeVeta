using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalpel : MonoBehaviour, IUseable
{
    // ������ ���� ���� ����
    Pillow pillow = null;
    // ������ ���� ���� ����
    //Doll doll = null;

    bool isUse = false;

    // ����� ��
    private void OnTriggerEnter(Collider other)
    {
        isUse = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isUse = false;
    }

    public void GetItem(Transform _pos)
    {
        transform.SetParent(_pos);
        transform.position = _pos.position;
    }

    public void Use(Collider _collider)
    {
        if (!isUse) return;
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