using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public GameObject cubeObj;

    public GameObject cubePrefab;



    //void Update()
    //{
    /*if (Input.GetKeyDown(KeyCode.Space))
    {
        //cubeObj.SetActive(false);

        Destroy(cubeObj,2f);
    }

    if (Input.GetKeyDown(KeyCode.Escape))
    {
        cubeObj.SetActive(true);
    }*/

    /*if (Input.GetKeyDown(KeyCode.Space))
    {
        Instantiate(cubePrefab, transform.position, transform.rotation);
    }*/


    //} 

    /*private void Start()
    {
        //Invoke("MakeCube", 2f);

        InvokeRepeating("MakeCube", 2f, 5f);
    }

    private void MakeCube()
    {
        Instantiate(cubePrefab, transform.position, Quaternion.identity);
    }*/

    /*private void Start()
    {
        print("start of start function");

        StartCoroutine(TestCoroutine());

        print("final of the start function");

        // coroutinedeki yield, startý 1 frame bekletmez!
        

    }

    IEnumerator TestCoroutine()
    {
        print("first frame");

        yield return null; //wait 1 frame

        print("second frame");
    }*/

    /*private void Start()
    {
        

        StartCoroutine(TestCoroutine());

        
        

    }



    IEnumerator TestCoroutine()
    {
        print("first frame");

        yield return new WaitForSeconds(2f);

        print("second frame");

        yield return new WaitForSeconds(4f);

        print("last frame");
    }
    */

    private void Start()
    {
        MakeCube();

    }

    private void MakeCube()
    {
        Instantiate(cubePrefab, transform.position, transform.rotation);
    }
}
