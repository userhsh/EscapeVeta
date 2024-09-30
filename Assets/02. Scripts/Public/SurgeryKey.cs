using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SurgeryKey : Key
{
    private void Awake()
    {
        SurgeryKeyInit();    
    }

    // SurgeryKey Init �޼���
    private void SurgeryKeyInit()
    {
        // ���� Ű�� SurgeryKey�� ����
        currentKey = KEY.SurgeryKey;
    }
}