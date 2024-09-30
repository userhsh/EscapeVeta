using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Key : MonoBehaviour, IUseable
{
    // �����ϴ� ������ ���� ���� ����
    protected MorgueDoor morgueDoor = null;
    protected ClassroomDoor classroomDoor = null;
    protected OfficeDoor officeDoor = null;
    protected SurgeryDoor surgeryDoor = null;

    // KEY ���¸� �Ǵ��� enum ���� ���� 
    protected enum KEY
    {
        MorgueKey,
        ClassroomKey,
        OfficeKey,
        SurgeryKey,
    }
    // ���� key ���¸� ������ ���� ����
    protected KEY currentKey = 0;

    // ������ ȹ�� �޼���
    public void GetItem(Transform _pos)
    {
        transform.SetParent(_pos);
        transform.position = _pos.position;
    }

    // ������ ��� �޼���
    // _collider�� ���ڷ� �޾Ƽ� ���
    public void Use(Collider _collider)
    {
        DoorUnLockFromKey(_collider);
    }

    // �� ��� ���� �޼���
    private void DoorUnLockFromKey(Collider _collider) // ���ڷ� _collider�� ����
    {
        // currentKey�� ���¿� ���� switch�� ����
        switch (currentKey)
        {
            // MorgueKey�� ��
            case KEY.MorgueKey:
                morgueDoor = _collider.gameObject.GetComponent<MorgueDoor>();
                morgueDoor?.DoorUnlock();
                break;
            // ClassroomKey�� ��
            case KEY.ClassroomKey:
                classroomDoor = _collider.gameObject.GetComponent<ClassroomDoor>();
                classroomDoor?.DoorUnlock();
                break;
            // OfficeKey�� ��
            case KEY.OfficeKey:
                officeDoor = _collider.gameObject.GetComponent<OfficeDoor>();
                officeDoor?.DoorUnlock();
                break;
            // SurgeryKey�� ��
            case KEY.SurgeryKey:
                surgeryDoor = _collider.gameObject.GetComponent<SurgeryDoor>();
                surgeryDoor?.DoorUnlock();
                break;
        }
    }
}