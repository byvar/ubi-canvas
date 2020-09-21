using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class OnEventSpawnerComponent : ActorComponent {
		public Path actorToSpawn;
		public CArrayO<Generic<Event>> onSpawnEvents;
		public bool autoStart;
		public EventSpawn spawnDataAutoStart;
		public Enum_SpawnObjectRef SpawnObjectRef;
		public Enum_SpawnPosRef SpawnPosRef;
		public uint KEY;
		public CArrayO<StringID> BoneGroups;
		public Path Path__0;
		public CArrayO<Generic<Event>> CArray_Generic_Event__1;
		public bool bool__2;
		public EventSpawn EventSpawn__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
				CArray_Generic_Event__1 = s.SerializeObject<CArrayO<Generic<Event>>>(CArray_Generic_Event__1, name: "CArray_Generic_Event__1");
				bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
				if (s.HasFlags(SerializeFlags.Default)) {
					EventSpawn__3 = s.SerializeObject<EventSpawn>(EventSpawn__3, name: "EventSpawn__3");
				}
			} else {
				actorToSpawn = s.SerializeObject<Path>(actorToSpawn, name: "actorToSpawn");
				onSpawnEvents = s.SerializeObject<CArrayO<Generic<Event>>>(onSpawnEvents, name: "onSpawnEvents");
				autoStart = s.Serialize<bool>(autoStart, name: "autoStart");
				if (s.HasFlags(SerializeFlags.Default)) {
					spawnDataAutoStart = s.SerializeObject<EventSpawn>(spawnDataAutoStart, name: "spawnDataAutoStart");
				}
				SpawnObjectRef = s.Serialize<Enum_SpawnObjectRef>(SpawnObjectRef, name: "SpawnObjectRef");
				SpawnPosRef = s.Serialize<Enum_SpawnPosRef>(SpawnPosRef, name: "SpawnPosRef");
				KEY = s.Serialize<uint>(KEY, name: "KEY");
				BoneGroups = s.SerializeObject<CArrayO<StringID>>(BoneGroups, name: "BoneGroups");
				KEY = s.Serialize<uint>(KEY, name: "KEY");
				BoneGroups = s.SerializeObject<CArrayO<StringID>>(BoneGroups, name: "BoneGroups");
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

