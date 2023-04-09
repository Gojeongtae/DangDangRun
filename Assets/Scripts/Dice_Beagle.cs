using UnityEngine;

public class Dice_Beagle : MonoBehaviour
{
    
    public float force = 10f; // �ֻ����� ���� �� ������ ���� ũ��
    public float torque = 10f; // �ֻ����� ���� �� ������ ȸ������ ũ��

    private bool isRolling = false; // �ֻ����� �������� �������� ����

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isRolling) // ���콺 ���� ��ư�� �����鼭 �ֻ����� �������� ���� �ƴ� ��
        {
            Roll(); // �ֻ����� ������.
        }


        Vector3 rotation = transform.rotation.eulerAngles;

        if (rotation.x >= -1 && rotation.x <= 1 &&
            rotation.z >= -1 && rotation.z <= 1)
        {
            Debug.Log("10");
        }
        else if((rotation.x >= -1 && rotation.x <= 1 &&
            rotation.z >= 89 && rotation.z <= 91))
        {
            Debug.Log("-3");
        }
        else if ((rotation.x >= 89 && rotation.x <= 91 &&
            rotation.z >= -1 && rotation.z <= 1))
        {
            Debug.Log("1");
        }
        else if ((rotation.x >= 0 && rotation.x <= 0 &&
           rotation.z >= 180 && rotation.z <= 180))
        {
            Debug.Log("8");
        }


    }

    void Roll()
    {
        isRolling = true; // �ֻ����� �������� ������ ǥ���Ѵ�.

        Rigidbody rb = GetComponent<Rigidbody>(); // �ֻ����� Rigidbody�� �����´�.

        rb.useGravity = true; // �߷��� �����Ѵ�.

        rb.AddForce(Random.onUnitSphere * force, ForceMode.Impulse); // �ֻ����� �������� ������.
        rb.AddTorque(Random.onUnitSphere * torque, ForceMode.Impulse); // �ֻ����� �������� ȸ����Ų��.

        Invoke("ResetDice", 5f); // 5�� �Ŀ� �ֻ����� �ʱ�ȭ�Ѵ�.
    }

    void ResetDice()
    {
        Rigidbody rb = GetComponent<Rigidbody>(); // �ֻ����� Rigidbody�� �����´�.

        rb.useGravity = false; // �߷��� �������� �ʴ´�.

        rb.velocity = Vector3.zero; // �ӵ��� �ʱ�ȭ�Ѵ�.
        rb.angularVelocity = Vector3.zero; // ���ӵ��� �ʱ�ȭ�Ѵ�.

        isRolling = false; // �ֻ����� �������� ���� �ƴ϶�� ǥ���Ѵ�.
    }
}