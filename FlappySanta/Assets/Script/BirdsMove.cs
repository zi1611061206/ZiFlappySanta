    using UnityEngine;
using System.Collections;

public class BirdsMove : MonoBehaviour
{

    public float moveSpeed;
    public float minY;
    public float maxY;

    public float oldPosition;
    private GameObject obj;
    // Use this for initialization
    void Start()
    {
        obj = gameObject;
        oldPosition = 10;
        moveSpeed = 5;
        minY = -1;
        maxY = 1;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("ResetBirds"))
            obj.transform.position = new Vector3(oldPosition, Random.Range(minY, maxY + 1), 0);
    }
}
