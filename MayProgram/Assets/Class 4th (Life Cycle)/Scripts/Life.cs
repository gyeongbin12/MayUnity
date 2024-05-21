using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    // Awake �Լ�\
    // ���� ������Ʈ�� �ν��Ͻ��� �Ŀ� �� �� ���� ȣ��Ǹ�,
    // ��ũ��Ʈ�� ��Ȱ��ȭ�Ǿ��� ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // OnEnable
    // ��ũ��Ʈ�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // Start
    // ���� ������Ʈ�� �ν��Ͻ��� �Ŀ� �� �� ���� ȣ��Ǹ�,
    // ��ũ��Ʈ�� Ȱ��ȭ�Ǿ��� ����, ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    void Start()
    {
        Debug.Log("Start");  
    }

    // FixedUpdate
    // TimeStep�� ������ ���� ���� ������ �������� ȣ��Ǵ�
    // �̺�Ʈ �Լ��Դϴ�.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // Update
    // �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    void Update()
    {
        Debug.Log("Update");
    }

    // LateUpdate
    // Update�Լ��� ���� �Ŀ� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    // OnDisable
    // ���� ������Ʈ ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    // OnDestroy
    // ���� ������Ʈ�� �ı��Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
