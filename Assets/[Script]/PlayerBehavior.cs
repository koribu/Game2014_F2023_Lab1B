using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yAxis = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        float xAxis = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        

        Debug.Log("This is X Axis Value: " +  xAxis);
        Debug.Log("This is Y Axis Value: " + yAxis);

        transform.position = new Vector3(transform.position.x + xAxis, transform.position.y + yAxis, 0);


    }
}
