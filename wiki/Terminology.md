## Scene elements
A scene mainly consists of multiple actors and multiple friezes.
* **Actor**: An actor is any object that behaves in a certain way. It can act on its own or react to events.
* **Frieze** or **Frise**: any kind of static scenery object, without special behaviors. It can have collision data (which would make it a platform), fluid data (for e.g. water), animation data (if it has some limited vertex animations, for example), and lots of material settings which makes this a very flexible object type.

An Actor consists of multiple components, or **ActorComponents**. There are thousands of these in the UbiArt codebase. For example, the `PlayerControllerComponent` which means that the actor is controlled by the player, the `TextureGraphicComponent` which just displays a texture that can be replaced by other components on the same actor, and so on.

Each Actor, each Frieze/Frise, each ActorComponent has a **Template**.
This template contains all of the data that is common across all actors/friezes/components with this same template.
You can also consider each actor/frieze/component an instance of that template, containing only the data that can be modified per instance. Usually, this means that the templates contain more data.

Templates usually have obvious names, like `ActorComponent_Template`, but one template does not follow this convention: `FriseConfig`, the template of a Frise.

## Class name prefixes
* **Ray**: "Rayman". Used during Rayman Origins' development. Classes prefixed with "Ray" were only used in Rayman Origins, Jungle Run and Fiesta Run
* **RO2**: "Rayman Origins 2"... so Rayman Legends. Used during Rayman Legends' development. These classes remain in the code base of games based on the Rayman Legends version of the engine, so they are used in Child of Light, Valiant Hearts and Rayman Adventures.
* **RLC**: "Rayman Legends Creatures", or something similar. A lot of Rayman Adventures-exclusive classes have this prefix.
* **COL**: "Child of Light". Only used in Child of Light
* **W1W**: something about World War 1? It's for Valiant Hearts.