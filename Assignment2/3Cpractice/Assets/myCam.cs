using UnityEngine;

public class myCam : MonoBehaviour
{
    public float distanceAway;    //相机到目标的水平距离
    public float distanceUp;      //相机到目标的垂直距离
    public float fixedRotationYaw;//相机的固定朝向
    public float smoothPosition;
    public float smoothRotation;
    public Transform target;

    void LateUpdate()
    {
        //设置摄像机位置
        float radian = fixedRotationYaw * Mathf.Deg2Rad;
        float offset_x = distanceAway * Mathf.Sin(radian);
        float offset_z = distanceAway * Mathf.Cos(radian);
        Vector3 targetPosition = target.position + new Vector3(-offset_x, distanceUp, -offset_z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothPosition);

        //设置摄像机旋转
        float lookDownAngle = Mathf.Atan2(distanceAway, distanceUp) * Mathf.Rad2Deg;
        Quaternion targetrotation = Quaternion.AngleAxis(fixedRotationYaw, Vector3.up)
* Quaternion.AngleAxis(lookDownAngle, Vector3.right);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetrotation, Time.deltaTime * smoothRotation);
    }
}