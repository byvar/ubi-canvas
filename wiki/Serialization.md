# The serializer
Serializing and deserializing in UbiArt is done using a `CSerializerObject`. There are multiple kinds of serializer objects, each storing data in a different way.

## Main serializer objects
* `CSerializerObjectBinary`: Serializes an object into a binary file. Used in all UbiArt games up to Rayman Legends.
* `CSerializerObjectTagBinary`: This is also a binary serializer, but it tries to be more efficient by storing each object as follows:
  - DWORD: CRC based on name of the variable and the type of the object
  - DWORD: size in bytes of the object
  - the serialized object

  By storing this CRC it is possible to skip serialization of default values and save space. This is the main serialization method in Rayman Adventures.

There are more implemented in the UbiArt code, but they are not used as far as I'm aware.

## Custom made serializer objects for ubi-canvas
* `CSerializerObjectBinaryWriter`: In the UbiArt code, each serializer object does both reading and writing, but at the moment I thought it was easier to separate the two, so we have a binary writer serializer.
* `CSerializerObjectUnityEditor`: Serializing an object will loop over every variable inside it. By using this powerful system to send all the data to the Unity inspector and back, ubi-canvas can display and edit all of those variables within Unity.

# The serializable
Each object that can be serialized by a `CSerializerObject` is `CSerializable`. A CSerializable has 3 main methods:
* `SerializeImpl`: Where the magic happens. This defines the order and logic used to store all of its fields into the files. The code inside these methods was directly generated from the UbiArt binaries.
* `OnPreSerialize`: If some logic needs to be done just before the object is serialized, it will be done here.
* `OnPostSerialize`: After (de)serializing, some fields usually need to be processed, such as loading external files based on fields that were just read from the current file. This is usually done in this method.

## Field serialization
To learn how fields are serialized, let's take a closer look at any of the classes implementing it. For example, in `Frise.cs`, you can find these fields:
```
[Serialize("UvX_Offset")] public float UvX_Offset;
[Serialize("UvY_Offset")] public float UvY_Offset;
[Serialize("UvX_Flip"  )] public bool UvX_Flip;
[Serialize("UvY_Flip"  )] public bool UvY_Flip;
```
The field name here is for internal use. The name used by serializer objects is defined by the `SerializeAttribute` linked to the field. The reason for this difference is that different games can have variables with the same names but different types that cannot easily be converted to each other.
In `SerializeImpl`, we find this block of code:
```
SerializeField(s, nameof(UvX_Offset));
SerializeField(s, nameof(UvY_Offset));
SerializeField(s, nameof(UvX_Flip), type: typeof(byte));
SerializeField(s, nameof(UvY_Flip), type: typeof(byte));
```
The arguments passed to `SerializeField` are the serializer object `s`, the field name, and optionally the type we want to serialize it as. In this case, `UvX_Offset` and `UvY_Offset` are stored as floats, since they have the float type normally. Usually in this engine, boolean values are stored in the same way as integers, as 4-byte DWORDs. However, in some cases, the engine developers decided to store them as single bytes instead to save space - hence the type argument.

## Null
In the same class as the above example, we can find this:
```
[Serialize("CollisionData")] public Nullable<Frise.CollisionData> collisionData;
```
Knowing that a Frise represents any kind of static scenery object, it is obvious that it does not always need collision data. This is done using the `Nullable` container. This consists of a field `read` that is serialized before the object. If it is read as true, the object is serialized immediately afterwards. If it is false, the object will be serialized as null.

## Generics
An Actor in UbiArt is something that behaves a certain way. This behavior is specified using many different `ActorComponents`. For example, the `Ray_PlayerControllerComponent` - guess what that does. To serialize these components, their type also needs to be stored - otherwise there is no way to tell what type of component they are.

In `Actor.cs`, you can find:
```
[Serialize("COMPONENTS")] public CArray<Generic<ActorComponent>> COMPONENTS;
```
Here, the `Generic` container stores the type of the object, just like `Nullable` stores whether it is null or not. The type is stored as a DWORD called the `ClassCRC`.

### ClassCRC
Almost each class has a different ClassCRC. It is simply a hash value based on the name of the class generated with a custom CRC algorithm (this algorithm can be found in the `StringID` class). The ClassCRC is stored both inside each class as well as in a huge dictionary of ClassCRCs linked to their types in the `ObjectFactory` class. The dictionary looks like this:
```
public class ObjectFactory {
	public static Dictionary<uint, Type> classes = new Dictionary<uint, Type> {
		{ 0xD02443D7, typeof(ITF.InGameTextComponent) },
		{ 0x539ED10A, typeof(ITF.Ray_UIFadeScreenComponent) },
		{ 0xDE0814AB, typeof(ITF.Ray_TimeAttackHUDResultsComponent) },
		{ 0xA6A37BDF, typeof(ITF.Ray_TimeAttackHUDTimerComponent) },
		{ 0xE7DC13E1, typeof(ITF.Ray_PlayerScoreComponent) },
		...
```
Using this dictionary, the serializer knows which type to instantiate when reading a certain ClassCRC.

There is also one special ClassCRC that is not in this dictionary: `0xFFFFFFFF` (-1) (or in Origins mode `0x00000000` (or 0)) means that the object is null, so nothing will be read after this value.

## Pure binary serializables
You will notice that most of the serializables' fields have proper field names, even though they were autogenerated from the games' binaries which usually strip such information. However, because the field name is required for special serializer objects like `CSerializerObjectTagBinary` to work, this information was kept in the binaries.

Some serializables were never going to be stored in any other format than binary, however, and consequently don't have official variable names. The class names are still correct, though, and I was able to figure out what a lot of the variables do and name them appropriately. These classes can be found in the `PureBinary` folder.