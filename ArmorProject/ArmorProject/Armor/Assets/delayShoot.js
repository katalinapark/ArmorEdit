#pragma strict


var Player: Transform;
var enemy: Transform;
var IsAttacking: boolean = false;
var Bullet: Rigidbody;
var SpawnPoint: Transform;
var Distance: Vector3;
var DistanceFrom: float;
var fireRate = 0.5;
var nextFire = 0;

function Update() {
    Attacking();

    // Calculate the distance between the player  the enemy

    Distance = (enemy.position - Player.position);
    Distance.y = 0;
    DistanceFrom = Distance.magnitude;
    Distance /= DistanceFrom;

    // If the player is 20m away from the enemy, ATTACK!

    if (DistanceFrom < 1000) {
        IsAttacking = true;
    }
    else {
        IsAttacking = false;
    }
}

function Attacking() {
    if (IsAttacking) {

        // The enemy isn't blind so it should face the player

        enemy.LookAt(Player);

        //Shoot

        if (Time.time > nextFire) {
            nextFire = Time.time + fireRate;

            var Shoot = Instantiate(Bullet, SpawnPoint.position, SpawnPoint.rotation);
            Shoot.AddForce(SpawnPoint.forward * 5000);
        }
    }
}
