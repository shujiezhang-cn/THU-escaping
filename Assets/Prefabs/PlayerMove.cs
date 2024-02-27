using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveControl : MonoBehaviour
{
    // 移动的速度
    public float walkSpeed = 3.0f;
    // 角色控制器
    public CharacterController PcharacterController = null;
    // Start is called before the first frame update
    void Start()
    {
        PcharacterController = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        // 获取水平、垂直轴偏移
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 确定前方向
        Vector3 moveDir = transform.right * h + transform.forward * v;
        // 移动
        PcharacterController.Move(moveDir * walkSpeed * Time.deltaTime);
    }
}