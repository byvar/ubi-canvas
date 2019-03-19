using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class OnEventSpawnerComponent : ActorComponent {
		[Serialize("actorToSpawn"             )] public Path actorToSpawn;
		[Serialize("onSpawnEvents"            )] public CArray<Generic<Event>> onSpawnEvents;
		[Serialize("autoStart"                )] public bool autoStart;
		[Serialize("spawnDataAutoStart"       )] public EventSpawn spawnDataAutoStart;
		[Serialize("SpawnObjectRef"           )] public Enum_SpawnObjectRef SpawnObjectRef;
		[Serialize("SpawnPosRef"              )] public Enum_SpawnPosRef SpawnPosRef;
		[Serialize("KEY"                      )] public uint KEY;
		[Serialize("BoneGroups"               )] public CArray<StringID> BoneGroups;
		[Serialize("Path__0"                  )] public Path Path__0;
		[Serialize("CArray<Generic<Event>>__1")] public CArray<Generic<Event>> CArray_Generic_Event__1;
		[Serialize("bool__2"                  )] public bool bool__2;
		[Serialize("EventSpawn__3"            )] public EventSpawn EventSpawn__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Path__0));
				SerializeField(s, nameof(CArray_Generic_Event__1));
				SerializeField(s, nameof(bool__2));
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(EventSpawn__3));
				}
			} else {
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
				SerializeField(s, nameof(KEY));
				SerializeField(s, nameof(BoneGroups));
			}
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

