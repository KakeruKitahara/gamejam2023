using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGoal : MonoBehaviour
{
    [SerializeField]
    public GameObject point1;
    [SerializeField]
    public GameObject point2;
    [SerializeField]
    public GameObject point3;
    [SerializeField]
    public GameObject pizza;


    private int r;
    // Start is called before the first frame update
    void Start()
    {
        r = (int)Random.Range(1.0f, 4.0f);
        print(r);

        if(r==1){
            Instantiate(pizza, point1.transform.position, Quaternion.identity);
        }
        if(r==2){
            Instantiate(pizza, point2.transform.position, Quaternion.Euler(-90f,0f,0f));
        }
        if(r==3){
            Instantiate(pizza, point3.transform.position, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
