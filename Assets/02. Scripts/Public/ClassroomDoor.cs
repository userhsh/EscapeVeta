using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassroomDoor : Door
{
    private void Awake()
    {
        ClassroomDoorInit();
    }

    // ��ü ��ġ�� �� init �޼���
    private void ClassroomDoorInit()
    {
        // ���� �ε�� �� �̸� ��������
        GetCurrentSceneName();

        // ���� ���� ���·� 
        isLocked = false;

        // �̵��� �� �̸� ��������
        if (currentSceneName == SCENENAME.HallwayScene.ToString()) // ���� ���� ���� ���̶�� 
        {
            // �̵��� �� �̸��� ��ü ��ġ�� �� �̸� ��������
            moveSceneName = SCENENAME.ClassroomScene.ToString();
        }
        else // ���� ���� ���� ���� �ƴ϶��
        {
            // �̵��� �� �̸��� ���� �� �̸� ��������
            moveSceneName = SCENENAME.HallwayScene.ToString();
        }
    }
}