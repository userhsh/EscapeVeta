using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorgueKey : Key
{
    private void Awake()
    {
        MorgueKeyInit();
    }

    // MorgueKey Init �޼���
    private void MorgueKeyInit()
    {
        // ���� Ű�� MorgueKey�� ����
        currentKey = KEY.MorgueKey;
    }
}