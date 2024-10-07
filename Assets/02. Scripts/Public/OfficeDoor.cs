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

        PlayerPositionInit();

        // ���� ��� ���·� 
        isLocked = false;

        // �̵��� �� �̸� ��������
        if (currentSceneName == SCENENAME.HallwayScene.ToString()) // ���� ���� ���� ���̶�� 
        {
            // �̵��� �� �̸��� �繫�� �� �̸� ��������
            moveSceneName = SCENENAME.OfficeScene.ToString();
        }
        else // ���� ���� ���� ���� �ƴ϶��
        {
            // �̵��� �� �̸��� ���� �� �̸� ��������
            moveSceneName = SCENENAME.HallwayScene.ToString();
        }
    }
}