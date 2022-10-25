# Understanding-the-Important-Functions-of-UNITY


<p> In this project, i analyze the important functions of Unity such as Awake, Start, Update,FixedUpdate,LateUpdate, Instantiate, Invoke and Coroutine. To see the differences between Awake and Start or Update and FixedUpdate, i wrote some simple code. Here is the code i wrote, you can also acces these codes in the ImportantFunctions/Assets/Script folder!</p>

<p>
    
    // Start is called before the first frame update
    /*void Start()
    {
        Debug.Log("feedback from Start function");
    }
    

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
        //kamera ayarlarında kullanılır genellikle.
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
</p>
<p>
    
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

        // coroutinedeki yield, startı 1 frame bekletmez!
        

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
</p>
