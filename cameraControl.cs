using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public GameObject Player;
    private Vector3 Pos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void LateUpdate() {
        Pos = Player.transform.position - gameObject.transform.position;
        Pos.z = 0;    //摄像机的图层不能变化，所以z一直是0
        gameObject.transform.position += Pos / 20;
    }
     

}
