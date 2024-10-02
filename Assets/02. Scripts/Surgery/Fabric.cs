using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabric : MonoBehaviour, IUseable
{
    // ��ǰ ���� ���� ����
    Medicine medicine = null;

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
        // _collider�� medicine ��������
        medicine = _collider.gameObject.GetComponent<Medicine>();
        // medicine�� ���ٸ� 
        if (medicine == null)
        {
            // �޼��� ����������
            return;
        }
        // medicine�� �����Ѵٸ� Interact ����
        medicine?.Interact();
        // õ ���� �ֱ�
        Destroy(this.gameObject);
    }
}