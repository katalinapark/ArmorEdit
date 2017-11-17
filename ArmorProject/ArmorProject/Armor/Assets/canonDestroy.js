#pragma strict


function OnTriggerEnter(other: Collider) {
    if (other.tag == "RicochetBall") {
        Debug.Log("hit");

        Destroy(gameObject);
    }



}
