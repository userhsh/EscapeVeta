using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurgeryDoor : Door
{
    private void Awake()
    {
        SurgeryDoorInit();
    }

    // ��ü ��ġ�� �� init �޼���
    private void SurgeryDoorInit()
    {      
        // ���� �ε�� �� �̸� ��������
        GetCurrentSceneName();

        // ���� ��� ���·� 
        isLocked = false;

        // �̵��� �� �̸� ��������
        if (currentSceneName == SCENENAME.HallwayScene.ToString()) // ���� ���� ���� ���̶�� 
        {
            // �̵��� �� �̸��� ������ �� �̸� ��������
            moveSceneName = SCENENAME.SurgeryScene.ToString();
        }
        else // ���� ���� ���� ���� �ƴ϶��
        {
            // �̵��� �� �̸��� ���� �� �̸� ��������
            moveSceneName = SCENENAME.HallwayScene.ToString();
        }
    }
}