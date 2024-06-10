using System.Numerics;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CamercaMovement : MonoBehaviour {

    [SerializeField] private Transform player;
    [SerializeField] private float distanceAhead;
    [SerializeField] private float cameraSpeed;
    private float moveAhead;


    private void FixedUpdate() {

        transform.position = new UnityEngine.Vector3(player.position.x + moveAhead, player.position.y, transform.position.z);
        moveAhead = Mathf.Lerp(moveAhead, (distanceAhead * player.localScale.x), Time.deltaTime * cameraSpeed);

    }


    









}