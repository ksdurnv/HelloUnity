using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //�ɹ� ���� ����
    public string itemName;
    public int damage;
    public float attackSpeed;
    public bool isBroken;

    private void Awake()
    {
        Debug.Log("Awake�޼��� ȣ���!");
        //���ݷ� : 0

        Debug.Log($"�����۸� : {this.itemName}");
        Debug.Log($"���ݷ� : {this.damage}");
        Debug.Log($"���ݼӵ� : {this.attackSpeed}");
        Debug.Log($"�ı����� : {this.isBroken}");

        Debug.LogFormat("���ݷ� : {0}", this.damage);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start�޼��� ȣ���!");
    }

    // Update is called once per frame
    void Update()
    {
        //�ּ� : ��Ʈ�� + k + c
        //�ּ� Ǯ�� : ��Ʈ�� + k + u
        //Debug.Log("Update");
    }
}
