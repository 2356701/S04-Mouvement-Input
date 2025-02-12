using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MouvementTranslateWorld : MonoBehaviour
{
    //[SerializeField] private float _x = 0f;
    //[SerializeField] private float _y = 0f;
    //[SerializeField] private float _z= 0f;



    //void Update()
    //{

    //  transform.Translate(_x*Time.deltaTime,_y * Time.deltaTime, _z * Time.deltaTime, Space.World);

    //    //Vector3 deplacement = new Vector3(1f, 0, 0);
    //    //transform.Translate(deplacement * Time.deltaTime, Space.World);
    //}

    [SerializeField] private Vector3 _deplacement;

    private void Update()
    {
        transform.Translate(_deplacement* Time.deltaTime , Space.World);
    }



}
