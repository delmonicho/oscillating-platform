using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    // the target we're going to be looking at
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        // calculate the relative position between this gameObject and the target
        Vector3 relativePos = target.position - transform.position;
        // Project the relative psotion onto the XZ plane to rotate the UFO around it's Y axis
        Vector3 relativePosXZ = Vector3.ProjectOnPlane(relativePos, Vector3.up);

        // create a look rotation to rotate the UFO in the direction of the relative position
        Quaternion lookRot = Quaternion.LookRotation(relativePos);

        // apply this rotation to our gameObject
        transform.rotation = lookRot;
    }
}
