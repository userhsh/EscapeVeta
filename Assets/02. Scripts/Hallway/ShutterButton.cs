using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutterButton : MonoBehaviour, IUseable
{
    // ��ư Ȩ ������ ���� ����
    ButtonHole buttonHole = null;

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
        // _collider�� ButtonHole ��������
        buttonHole = _collider.GetComponent<ButtonHole>();
        // ���� ��ư Ȧ�� �������� ���ߴٸ�
        if (buttonHole == null ) 
        {
            // ����������
            return;
        }
        // ��ưȦ�� null�� �ƴϸ� Interact ����
        buttonHole?.Interact();
        // ��ư ���� �ֱ�
        Destroy(this.gameObject);
    }
}