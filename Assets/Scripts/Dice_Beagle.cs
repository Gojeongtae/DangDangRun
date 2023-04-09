using UnityEngine;

public class Dice_Beagle : MonoBehaviour
{
    
    public float force = 10f; // 주사위를 굴릴 때 적용할 힘의 크기
    public float torque = 10f; // 주사위를 굴릴 때 적용할 회전력의 크기

    private bool isRolling = false; // 주사위가 굴러가는 도중인지 여부

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isRolling) // 마우스 왼쪽 버튼이 눌리면서 주사위가 굴러가는 중이 아닐 때
        {
            Roll(); // 주사위를 굴린다.
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
        isRolling = true; // 주사위가 굴러가는 중임을 표시한다.

        Rigidbody rb = GetComponent<Rigidbody>(); // 주사위의 Rigidbody를 가져온다.

        rb.useGravity = true; // 중력을 적용한다.

        rb.AddForce(Random.onUnitSphere * force, ForceMode.Impulse); // 주사위를 무작위로 굴린다.
        rb.AddTorque(Random.onUnitSphere * torque, ForceMode.Impulse); // 주사위를 무작위로 회전시킨다.

        Invoke("ResetDice", 5f); // 5초 후에 주사위를 초기화한다.
    }

    void ResetDice()
    {
        Rigidbody rb = GetComponent<Rigidbody>(); // 주사위의 Rigidbody를 가져온다.

        rb.useGravity = false; // 중력을 적용하지 않는다.

        rb.velocity = Vector3.zero; // 속도를 초기화한다.
        rb.angularVelocity = Vector3.zero; // 각속도를 초기화한다.

        isRolling = false; // 주사위가 굴러가는 중이 아니라고 표시한다.
    }
}