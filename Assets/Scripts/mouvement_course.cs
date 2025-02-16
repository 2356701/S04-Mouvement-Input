using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement_course : MonoBehaviour
{
    private float _vitesse = 1f;
    private Vector3 _deplacement ;



    // Start is called before the first frame update
    void Start()
    {
      _vitesse = Random.Range(0.01f, 5f);
    }

    // Update is called once per frame

    






    // Update is called once per frame
    void Update()
    {


      
        transform.Translate(0,0, _vitesse*Time.deltaTime);
        if(transform.position.x > 5f)
        {
            Debug.Log(gameObject.name);
        }

   

    }
}
