using UnityEngine;

public class Dice_Beagle : MonoBehaviour
{


    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // 주사위의 면에 숫자를 표시
        transform.Find("Front").GetComponentInChildren<TextMesh>().text = (1).ToString();
        transform.Find("Back").GetComponentInChildren<TextMesh>().text = (2).ToString();
        transform.Find("Right").GetComponentInChildren<TextMesh>().text = (3).ToString();
        transform.Find("Left").GetComponentInChildren<TextMesh>().text = (4).ToString();
        transform.Find("Top").GetComponentInChildren<TextMesh>().text = (5).ToString();
        transform.Find("Bottom").GetComponentInChildren<TextMesh>().text = (6).ToString();
    }

    void Update()
    {
        // 주사위가 멈췄는지 여부를 판단
        if (rb.IsSleeping())
        {
            // 주사위의 회전값을 가져옴
            Quaternion rotation = transform.rotation;

            // 윗면의 숫자를 찾음
            Vector3 up = rotation * Vector3.up;
            int number = Mathf.RoundToInt(up.y);

            // 윗면의 숫자와 내가 설정한 숫자가 같으면, 이를 출력

            Debug.Log("윗면에 " + number + "이 나왔습니다");
        }
    }
}
