# Unity

## Movement 

To make a GameObject respond to gravity and scripted forces, you need to attach a *Rigidbody* and check the ```use gravity``` box. Add a *Collider* for your GameObject to respond to contact with other GameObjects. 

#### Using the physics engine
For scripted forces, use ```AddForce()``` (or ```AddTorque()```). Don’t alter the Transform component. Leave the *Collider* unaltered to make your GameObject responds to contact with other GameObjects.

#### DIY
Check the is kinematic box on the *Rigidbody*. The physics engine won't apply forces and ignores collisions for this GameObject. The GameObject will still affect other objects with physics.
- You can now alter the Transform component to move the GameObject
- Check the ```is trigger``` box on the *Collider* to trigger an event when your GameObjects contacts another GameObject with a *non-kinematic RigidBody* or an *is trigger Collider*.

## Collissions

#### GameObject and dead obstacle

When the obstacle GameObject shouldn't physically react in any way to a colliding GameObject, leave out the *RigidBody* or check ```is kinematic``` on it. 

Check ```is trigger``` on the obstacle GameObject *Collider*. It's not necessary to check this on the other (player) GameObject as well: only one of the GameObjects needs to be a trigger. A trigger event (e.g. ```OnTriggerEnter(Collider other)```) is sent to both *Colliders* and if present, the *Rigidbodies* attached to them. 
