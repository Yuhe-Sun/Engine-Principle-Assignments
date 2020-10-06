using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        //var blocks = new List<Vector3>() { red1, red2, orange1, orange2, yellow1,
        //    yellow2, green1, green2, cyan1, cyan2, blue1, blue2, purple1,
        //    purple2, pink1, pink2, grey1, grey2, black1, black2 };

        //Vector3 red1Position = GameObject.Find("red1").transform.position;
        //Vector3 red2Position = GameObject.Find("red2").transform.position;

        //foreach (var block in blocks)
        //{
        //    //string posName = block + "Position";
        //    Vector3 block = GameObject.Find($"block).transform.position;

        //}


        //foreach (var block in blocks)
        //{
        //    Vector3 block = GameObject.Find(nameof(block)).transform.position;
        //}

        Vector3 player = GameObject.Find("Player").transform.position;

        Vector3 red1 = GameObject.Find("red1").transform.position;
        Vector3 red2 = GameObject.Find("red2").transform.position;
        Vector3 orange1 = GameObject.Find("orange1").transform.position;
        Vector3 orange2 = GameObject.Find("orange2").transform.position;
        Vector3 yellow1 = GameObject.Find("yellow1").transform.position;
        Vector3 yellow2 = GameObject.Find("yellow2").transform.position;
        Vector3 green1 = GameObject.Find("green1").transform.position;
        Vector3 green2 = GameObject.Find("green2").transform.position;
        Vector3 cyan1 = GameObject.Find("cyan1").transform.position;
        Vector3 cyan2 = GameObject.Find("cyan2").transform.position;
        Vector3 blue1 = GameObject.Find("blue1").transform.position;
        Vector3 blue2 = GameObject.Find("blue2").transform.position;
        Vector3 purple1 = GameObject.Find("purple1").transform.position;
        Vector3 purple2 = GameObject.Find("purple2").transform.position;
        Vector3 pink1 = GameObject.Find("pink1").transform.position;
        Vector3 pink2 = GameObject.Find("pink2").transform.position;
        Vector3 grey1 = GameObject.Find("grey1").transform.position;
        Vector3 grey2 = GameObject.Find("grey2").transform.position;
        Vector3 black1 = GameObject.Find("black1").transform.position;
        Vector3 black2 = GameObject.Find("black2").transform.position;


        if (collision.gameObject.name == "red1")
        {
            transform.position = new Vector3(red2.x, 5f, red2.z);
        }

        if (collision.gameObject.name == "red2")
        {
            transform.position = new Vector3(red1.x, 5f, red1.z);
        }

        if (collision.gameObject.name == "orange1")
        {
            transform.position = new Vector3(orange2.x, 5f, orange2.z);
        }

        if (collision.gameObject.name == "orange2")
        {
            transform.position = new Vector3(orange1.x, 5f, orange1.z);
        }

        if (collision.gameObject.name == "yellow1")
        {
            transform.position = new Vector3(yellow2.x, 5f, yellow2.z);
        }

        if (collision.gameObject.name == "yellow2")
        {
            transform.position = new Vector3(yellow1.x, 5f, yellow1.z);
        }

        if (collision.gameObject.name == "green1")
        {
            transform.position = new Vector3(green2.x, 5f, green2.z);
        }

        if (collision.gameObject.name == "green2")
        {
            transform.position = new Vector3(green1.x, 5f, green1.z);
        }

        if (collision.gameObject.name == "cyan1")
        {
            transform.position = new Vector3(cyan2.x, 5f, cyan2.z);
        }

        if (collision.gameObject.name == "cyan2")
        {
            transform.position = new Vector3(cyan1.x, 5f, cyan1.z);
        }

        if (collision.gameObject.name == "blue1")
        {
            transform.position = new Vector3(blue2.x, 5f, blue2.z);
        }

        if (collision.gameObject.name == "blue2")
        {
            transform.position = new Vector3(blue1.x, 5f, blue1.z);
        }

        if (collision.gameObject.name == "purple1")
        {
            transform.position = new Vector3(purple2.x, 5f, purple2.z);
        }

        if (collision.gameObject.name == "purple2")
        {
            transform.position = new Vector3(purple1.x, 5f, purple1.z);
        }

        if (collision.gameObject.name == "pink1")
        {
            transform.position = new Vector3(pink2.x, 5f, pink2.z);
        }

        if (collision.gameObject.name == "pink2")
        {
            transform.position = new Vector3(pink1.x, 5f, pink1.z);
        }

        if (collision.gameObject.name == "grey1")
        {
            transform.position = new Vector3(grey2.x, 5f, grey2.z);
        }

        if (collision.gameObject.name == "grey2")
        {
            transform.position = new Vector3(grey1.x, 5f, grey1.z);
        }

        if (collision.gameObject.name == "black1")
        {
            transform.position = new Vector3(black2.x, 5f, black2.z);
        }

        if (collision.gameObject.name == "black2")
        {
            transform.position = new Vector3(black1.x, 5f, black1.z);
        }



    }
}
