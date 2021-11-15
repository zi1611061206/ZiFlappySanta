using UnityEngine;
using System.Collections;

public class BackGroundMove : MonoBehaviour
{

    public float moveSpeed; //Biến lưu thông số về tốc độ di chuyển
    public float moveDistance; //Biến lưu thông số về khoảng cách đã di chuyển so với vi trí ban đầu
    public Vector3 oldPosition; //Biến lưu thông số về vị trí ban đầu
    private GameObject obj; //Là đối tượng được gắn source này

    // Use this for initialization
    void Start()
    {
        obj = gameObject;
        moveSpeed = 2;
        moveDistance = 18.18542F*2;
        oldPosition = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, transform.position.y, 0));
        if (Vector3.Distance(oldPosition, obj.transform.position) > moveDistance)
        {
            obj.transform.position = oldPosition;
        }
    }
}
