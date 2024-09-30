using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeKey : Key
{
    private void Awake()
    {
        OfficeKeyInit();
    }

    // OfficeKey Init �޼���
    private void OfficeKeyInit()
    {
        // ���� Ű�� OfficeKey�� ����
        currentKey = KEY.OfficeKey;
    }
}