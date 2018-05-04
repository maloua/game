# Unity

## Movement 

To make a GameObject respond to gravity and scripted forces, you need to attach a *Rigidbody* and check the ```use gravity``` box. Add a *Collider* for your GameObject to respond to contact with other GameObjects. 

#### Using the physics engine
For scripted forces, use ```AddForce()``` (or ```AddTorque()```). Don’t alter the Transform component. Leave the *Collider* unaltered to make your GameObject responds to contact with other GameObjects.

#### DIY
Check the is kinematic box on the *Rigidbody*. The physics engine won't apply forces and ignores collisions for this GameObject. The GameObject will still affect other objects with physics.
- You can now alter the Transform component to move the GameObject
- Check the ```is trigger``` box on the *Collider* to trigger an event when your GameObjects contacts another GameObject with a *non-kinematic RigidBody* or an *is-trigger Collider*.
