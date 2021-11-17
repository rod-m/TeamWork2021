using System;
using UnityEngine;

namespace rod_martin
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] public PlayerProps playerProps;

        private void Start()
        {
            // test commit
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(playerProps.speed * -Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(playerProps.speed * Time.deltaTime, 0, 0);
            }
        }
    }
}