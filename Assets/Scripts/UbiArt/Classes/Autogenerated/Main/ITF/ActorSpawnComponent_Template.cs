using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class ActorSpawnComponent_Template : ActorComponent_Template {
		[Serialize("spawnDelayed"        )] public bool spawnDelayed;
		[Serialize("spawnActors"         )] public CList<ActorSpawnComponent_Template.SpawnData> spawnActors;
		[Serialize("transmitAlwaysActive")] public bool transmitAlwaysActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(spawnDelayed));
				SerializeField(s, nameof(spawnActors));
			} else {
				SerializeField(s, nameof(spawnDelayed));
				SerializeField(s, nameof(spawnActors));
				SerializeField(s, nameof(transmitAlwaysActive));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
		public partial class SpawnData : CSerializable {
			[Serialize("actorLua"               )] public Path actorLua;
			[Serialize("spawnActorBoneName"     )] public string spawnActorBoneName;
			[Serialize("polyline"               )] public StringID polyline;
			[Serialize("polylinePoint"          )] public StringID polylinePoint;
			[Serialize("useParentScale"         )] public bool useParentScale;
			[Serialize("useParentFlip"          )] public bool useParentFlip;
			[Serialize("useParentAngle"         )] public bool useParentAngle;
			[Serialize("offset"                 )] public Vec3d offset;
			[Serialize("keepSpawneeInitialDepth")] public bool keepSpawneeInitialDepth;
			[Serialize("BasicString__1"         )] public BasicString spawnActorBoneNameB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
					SerializeField(s, nameof(actorLua));
					SerializeField(s, nameof(spawnActorBoneNameB));
					SerializeField(s, nameof(polyline));
					SerializeField(s, nameof(polylinePoint));
					SerializeField(s, nameof(useParentScale));
					SerializeField(s, nameof(useParentFlip));
					SerializeField(s, nameof(useParentAngle));
					SerializeField(s, nameof(offset));
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

