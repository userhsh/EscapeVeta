using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorgueDoor : Door
{
    private void Awake()
    {
        MorgueDoorInit();
    }

    // ��ü ��ġ�� �� init �޼���
    private void MorgueDoorInit()
    {
        // ���� �ε�� �� �̸� ��������
        GetCurrentSceneName();

        // ���� ��� ���·� 
        isLocked = false;

        // �̵��� �� �̸� ��������
        if (currentSceneName == SCENENAME.HallwayScene.ToString()) // ���� ���� ���� ���̶�� 
        {
            // �̵��� �� �̸��� ��ü ��ġ�� �� �̸� ��������
            moveSceneName = SCENENAME.MorgueScene.ToString();
        }
        else // ���� ���� ���� ���� �ƴ϶��
        {
            // �̵��� �� �̸��� ���� �� �̸� ��������
            moveSceneName = SCENENAME.HallwayScene.ToString();
        }
    }
}