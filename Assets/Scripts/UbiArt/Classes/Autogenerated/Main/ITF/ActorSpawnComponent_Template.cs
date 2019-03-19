using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class ActorSpawnComponent_Template : ActorComponent_Template {
		[Serialize("spawnDelayed"        )] public bool spawnDelayed;
		[Serialize("spawnActors"         )] public CList<ActorSpawnComponent_Template.SpawnData> spawnActors;
		[Serialize("transmitAlwaysActive")] public bool transmitAlwaysActive;
		[Serialize("spawnDelayed"        )] public int spawnDelayed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(spawnDelayed));
				SerializeField(s, nameof(spawnActors));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(spawnDelayed));
				SerializeField(s, nameof(transmitAlwaysActive));
			} else {
				SerializeField(s, nameof(spawnDelayed));
				SerializeField(s, nameof(spawnActors));
				SerializeField(s, nameof(transmitAlwaysActive));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
		public partial class SpawnData : CSerializable {
			[Serialize("actorLua"               )] public Path actorLua;
			[Serialize("spawnActorBoneName"     )] public string spawnActorBoneName;
			[Serialize("polyline"               )] public StringID polyline;
			[Serialize("polylinePoint"          )] public StringID polylinePoint;
			[Serialize("useParentScale"         )] public bool useParentScale;
			[Serialize("useParentFlip"          )] public bool useParentFlip;
			[Serialize("useParentAngle"         )] public bool useParentAngle;
			[Serialize("offset"                 )] public Vector3 offset;
			[Serialize("keepSpawneeInitialDepth")] public bool keepSpawneeInitialDepth;
			[Serialize("Path__0"                )] public Path Path__0;
			[Serialize("BasicString__1"         )] public BasicString BasicString__1;
			[Serialize("StringID__2"            )] public StringID StringID__2;
			[Serialize("StringID__3"            )] public StringID StringID__3;
			[Serialize("int__4"                 )] public int int__4;
			[Serialize("int__5"                 )] public int int__5;
			[Serialize("int__6"                 )] public int int__6;
			[Serialize("Vector3__7"             )] public Vector3 Vector3__7;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
					SerializeField(s, nameof(Path__0));
					SerializeField(s, nameof(BasicString__1));
					SerializeField(s, nameof(StringID__2));
					SerializeField(s, nameof(StringID__3));
					SerializeField(s, nameof(int__4));
					SerializeField(s, nameof(int__5));
					SerializeField(s, nameof(int__6));
					SerializeField(s, nameof(Vector3__7));
				} else {
					SerializeField(s, nameof(actorLua));
					SerializeField(s, nameof(spawnActorBoneName));
					SerializeField(s, nameof(polyline));
					SerializeField(s, nameof(polylinePoint));
					SerializeField(s, nameof(useParentScale));
					SerializeField(s, nameof(useParentFlip));
					SerializeField(s, nameof(useParentAngle));
					SerializeField(s, nameof(offset));
					SerializeField(s, nameof(keepSpawneeInitialDepth));
				}
			}
		}
		public override uint? ClassCRC => 0xD19263B5;
	}
}

