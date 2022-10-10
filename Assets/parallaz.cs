using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaz : MonoBehaviour
{
    GameObject player;
    Renderer Rend;
    float playerstartPos;
    void Start()
    {
        player = GameObject.Find("player");
        rend = GetComponent<Renderer>();
        playerStartPos = player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = (player.transform.position.x - playerStartPos) * speed;

        Rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
    }
}
