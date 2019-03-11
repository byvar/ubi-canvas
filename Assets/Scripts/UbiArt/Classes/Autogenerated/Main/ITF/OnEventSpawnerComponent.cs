using UnityEngine;

namespace UbiArt.ITF {
	public partial class OnEventSpawnerComponent : ActorComponent {
		[Serialize("actorToSpawn"      )] public Path actorToSpawn;
		[Serialize("onSpawnEvents"     )] public CArray<Generic<Event>> onSpawnEvents;
		[Serialize("autoStart"         )] public bool autoStart;
		[Serialize("spawnDataAutoStart")] public EventSpawn spawnDataAutoStart;
		[Serialize("SpawnObjectRef"    )] public Enum_SpawnObjectRef SpawnObjectRef;
		[Serialize("SpawnPosRef"       )] public Enum_SpawnPosRef SpawnPosRef;
		[Serialize("KEY"               )] public uint KEY;
		[Serialize("BoneGroups"        )] public CArray<StringID> BoneGroups;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorToSpawn));
			SerializeField(s, nameof(onSpawnEvents));
			SerializeField(s, nameof(autoStart));
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(spawnDataAutoStart));
			}
			SerializeField(s, nameof(SpawnObjectRef));
			SerializeField(s, nameof(SpawnPosRef));
			SerializeField(s, nameof(KEY));
			SerializeField(s, nameof(BoneGroups));
		}
		public enum Enum_SpawnObjectRef {
			[Serialize("eSelf"     )] eSelf = 0,
			[Serialize("eLinkChild")] eLinkChild = 1,
		}
		public enum Enum_SpawnPosRef {
			[Serialize("eObjectPos")] eObjectPos = 0,
			[Serialize("eBonePos"  )] eBonePos = 1,
		}
		public override uint? ClassCRC => 0xCDBC1FC4;
	}
}

