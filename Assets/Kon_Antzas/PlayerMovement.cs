using rod_martin;
using UnityEngine;
using UnityEngine.Serialization;

namespace Kon_Antzas
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] public PlayerProp playerProp;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.Translate(playerProp.speed, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Translate(playerProp.speed, 0, 0);
            }
        }
    }
}