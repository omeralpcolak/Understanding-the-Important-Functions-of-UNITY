using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        Debug.Log("feedback from Start function");
    }
    
    OBJE AKTÝF OLMASA BÝLE AWAKE ÇALIÞIR.

    private void Awake()
    {
        Debug.Log("feedback from Awake function");
    } */

    /*private void OnEnable()
    {
        print("object is activated!");
    }

    private void OnDisable()
    {
        print("object is deactivated!");
    }*/

    /*private void OnBecameVisible()
    {
        print("object is in the scene!");
    }

    private void OnBecameInvisible()
    {
        print("object is out of the scene!");
    }*/


    /* private void Update()
    {   
        print("coming from Update function!");
    }

    private void FixedUpdate()
    {
        print("coming from FixedUpdate function!");
    }

    private void LateUpdate()
    {   
        //kamera ayarlarýnda kullanýlýr genellikle.
        print("coming from LateUpdate function!");
    }*/

    /*public float speed = 5f;

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }*/

    private float totalTime = 5f;
    private float passingTime = 0f;

    private void Start()
    {

        StartCoroutine(MoveCubeCoroutine());
    }



    IEnumerator MoveCubeCoroutine()
    {


        Vector3 firstPosition = transform.position;
        Vector3 finalPosition = new Vector3(10f, 10f, 10f);

        while (passingTime < totalTime)
        {
            passingTime += Time.deltaTime;
            transform.position = Vector3.Lerp(firstPosition, finalPosition, passingTime / totalTime);

            yield return null;
        }

        transform.position = finalPosition;
    }
}
