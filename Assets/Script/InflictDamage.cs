using UnityEngine;

public class InflictDamage : MonoBehaviour
{

    public static int damageAmount = 5;
    public float targetDistance;
    public float allowedRange = 3.1f;

    void Update()
    {
        if (AxeSwing.holdingAxe == true)
        {
            if (Input.GetButtonDown("Fire1") && AxeSwing.isSwinging == true)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
                {
                    targetDistance = hit.distance;
                    if (targetDistance <= allowedRange)
                    {
                        hit.transform.SendMessage("DeductPoints", damageAmount, SendMessageOptions.DontRequireReceiver);
                    }
                }
            }
        }
    }
}
