using UnityEngine;

public class Dice_Beagle : MonoBehaviour
{


    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // �ֻ����� �鿡 ���ڸ� ǥ��
        transform.Find("Front").GetComponentInChildren<TextMesh>().text = (1).ToString();
        transform.Find("Back").GetComponentInChildren<TextMesh>().text = (2).ToString();
        transform.Find("Right").GetComponentInChildren<TextMesh>().text = (3).ToString();
        transform.Find("Left").GetComponentInChildren<TextMesh>().text = (4).ToString();
        transform.Find("Top").GetComponentInChildren<TextMesh>().text = (5).ToString();
        transform.Find("Bottom").GetComponentInChildren<TextMesh>().text = (6).ToString();
    }

    void Update()
    {
        // �ֻ����� ������� ���θ� �Ǵ�
        if (rb.IsSleeping())
        {
            // �ֻ����� ȸ������ ������
            Quaternion rotation = transform.rotation;

            // ������ ���ڸ� ã��
            Vector3 up = rotation * Vector3.up;
            int number = Mathf.RoundToInt(up.y);

            // ������ ���ڿ� ���� ������ ���ڰ� ������, �̸� ���

            Debug.Log("���鿡 " + number + "�� ���Խ��ϴ�");
        }
    }
}
