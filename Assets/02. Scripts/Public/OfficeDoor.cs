using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeDoor : Door
{
    private void Awake()
    {
        OfficeDoorInit();
    }

    // ��ü ��ġ�� �� init �޼���
    private void OfficeDoorInit()
    {
        // ���� �ε�� �� �̸� ��������
        GetCurrentSceneName();

        // ���� ��� ���·� 
        isLocked = true;

        // �̵��� �� �̸� ��������
        if (currentSceneName == SCENENAME.HallwayScene.ToString()) // ���� ���� ���� ���̶�� 
        {
            // �̵��� �� �̸��� ��ü ��ġ�� �� �̸� ��������
            moveSceneName = SCENENAME.OfficeScene.ToString();
        }
        else // ���� ���� ���� ���� �ƴ϶��
        {
            // �̵��� �� �̸��� ���� �� �̸� ��������
            moveSceneName = SCENENAME.HallwayScene.ToString();
        }
    }
}