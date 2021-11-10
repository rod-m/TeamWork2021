using System;
using UnityEngine;

namespace rod_martin
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] public PlayerProps playerProps;

        private void Start()
        {
            
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.Translate(playerProps.speed, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Translate(playerProps.speed, 0, 0);
            }
        }
    }
}