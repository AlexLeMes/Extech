using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    GameObject player;
    Transform pTrans;

    public float xDis = 0f;
    public float yDis = 0f;
    public float zDis = 0f;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        pTrans = player.GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position = new Vector3(pTrans.position.x + xDis, pTrans.position.y + yDis, pTrans.position.z + zDis);
    }
}
