using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class ActorSpawnComponent_Template : ActorComponent_Template {
		public bool spawnDelayed;
		public CListO<ActorSpawnComponent_Template.SpawnData> spawnActors;
		public bool transmitAlwaysActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				spawnDelayed = s.Serialize<bool>(spawnDelayed, name: "spawnDelayed");
				spawnActors = s.SerializeObject<CListO<ActorSpawnComponent_Template.SpawnData>>(spawnActors, name: "spawnActors");
			} else {
				spawnDelayed = s.Serialize<bool>(spawnDelayed, name: "spawnDelayed");
				spawnActors = s.SerializeObject<CListO<ActorSpawnComponent_Template.SpawnData>>(spawnActors, name: "spawnActors");
				transmitAlwaysActive = s.Serialize<bool>(transmitAlwaysActive, name: "transmitAlwaysActive");
			}
		}
		[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
		public partial class SpawnData : CSerializable {
			public Path actorLua;
			public string spawnActorBoneName;
			public StringID polyline;
			public StringID polylinePoint;
			public bool useParentScale;
			public bool useParentFlip;
			public bool useParentAngle;
			public Vec3d offset;
			public bool keepSpawneeInitialDepth;
			public BasicString spawnActorBoneNameB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
					actorLua = s.SerializeObject<Path>(actorLua, name: "actorLua");
					spawnActorBoneNameB = s.SerializeObject<BasicString>(spawnActorBoneNameB, name: "spawnActorBoneNameB");
					polyline = s.SerializeObject<StringID>(polyline, name: "polyline");
					polylinePoint = s.SerializeObject<StringID>(polylinePoint, name: "polylinePoint");
					useParentScale = s.Serialize<bool>(useParentScale, name: "useParentScale");
					useParentFlip = s.Serialize<bool>(useParentFlip, name: "useParentFlip");
					useParentAngle = s.Serialize<bool>(useParentAngle, name: "useParentAngle");
					offset = s.SerializeObject<Vec3d>(offset, name: "offset");
				} else {
					actorLua = s.SerializeObject<Path>(actorLua, name: "actorLua");
					spawnActorBoneName = s.Serialize<string>(spawnActorBoneName, name: "spawnActorBoneName");
					polyline = s.SerializeObject<StringID>(polyline, name: "polyline");
					polylinePoint = s.SerializeObject<StringID>(polylinePoint, name: "polylinePoint");
					useParentScale = s.Serialize<bool>(useParentScale, name: "useParentScale");
					useParentFlip = s.Serialize<bool>(useParentFlip, name: "useParentFlip");
					useParentAngle = s.Serialize<bool>(useParentAngle, name: "useParentAngle");
					offset = s.SerializeObject<Vec3d>(offset, name: "offset");
					keepSpawneeInitialDepth = s.Serialize<bool>(keepSpawneeInitialDepth, name: "keepSpawneeInitialDepth");
				}
			}
		}
		public override uint? ClassCRC => 0xD19263B5;
	}
}

