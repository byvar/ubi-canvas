using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionThrowObject_Template : BTAction_Template {
		public Generic<PhysShape> enemyDetectionRange;
		public StringID anim;
		public StringID markerSpawn;
		public StringID markerLaunch;
		public StringID markerStartSpawneeDig;
		public StringID boneSnap;
		public CListO<RO2_BTActionThrowObject_Template.ProjectileData> projectiles;
		public CListO<RO2_BTActionThrowObject_Tools.LaunchData> launchData;
		public StringID customPhantomShape;
		public StringID customPhantomShapeEventOn;
		public StringID customPhantomShapeEventOff;
		public Vec2d quickLaunchOffset;
		public bool debug;
		public CListO<RO2_BTActionThrowObject_Template.ProjectileData> projectileData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
				anim = s.SerializeObject<StringID>(anim, name: "anim");
				markerSpawn = s.SerializeObject<StringID>(markerSpawn, name: "markerSpawn");
				markerLaunch = s.SerializeObject<StringID>(markerLaunch, name: "markerLaunch");
				markerStartSpawneeDig = s.SerializeObject<StringID>(markerStartSpawneeDig, name: "markerStartSpawneeDig");
				boneSnap = s.SerializeObject<StringID>(boneSnap, name: "boneSnap");
				projectileData = s.SerializeObject<CListO<RO2_BTActionThrowObject_Template.ProjectileData>>(projectileData, name: "projectileData");
				launchData = s.SerializeObject<CListO<RO2_BTActionThrowObject_Tools.LaunchData>>(launchData, name: "launchData");
				customPhantomShape = s.SerializeObject<StringID>(customPhantomShape, name: "customPhantomShape");
				customPhantomShapeEventOn = s.SerializeObject<StringID>(customPhantomShapeEventOn, name: "customPhantomShapeEventOn");
				customPhantomShapeEventOff = s.SerializeObject<StringID>(customPhantomShapeEventOff, name: "customPhantomShapeEventOff");
				quickLaunchOffset = s.SerializeObject<Vec2d>(quickLaunchOffset, name: "quickLaunchOffset");
				debug = s.Serialize<bool>(debug, name: "debug");
			} else {
				enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
				anim = s.SerializeObject<StringID>(anim, name: "anim");
				markerSpawn = s.SerializeObject<StringID>(markerSpawn, name: "markerSpawn");
				markerLaunch = s.SerializeObject<StringID>(markerLaunch, name: "markerLaunch");
				markerStartSpawneeDig = s.SerializeObject<StringID>(markerStartSpawneeDig, name: "markerStartSpawneeDig");
				boneSnap = s.SerializeObject<StringID>(boneSnap, name: "boneSnap");
				projectiles = s.SerializeObject<CListO<RO2_BTActionThrowObject_Template.ProjectileData>>(projectiles, name: "projectiles");
				launchData = s.SerializeObject<CListO<RO2_BTActionThrowObject_Tools.LaunchData>>(launchData, name: "launchData");
				customPhantomShape = s.SerializeObject<StringID>(customPhantomShape, name: "customPhantomShape");
				customPhantomShapeEventOn = s.SerializeObject<StringID>(customPhantomShapeEventOn, name: "customPhantomShapeEventOn");
				customPhantomShapeEventOff = s.SerializeObject<StringID>(customPhantomShapeEventOff, name: "customPhantomShapeEventOff");
				quickLaunchOffset = s.SerializeObject<Vec2d>(quickLaunchOffset, name: "quickLaunchOffset");
				debug = s.Serialize<bool>(debug, name: "debug");
			}
		}
		[Games(GameFlags.RA)]
		public partial class ProjectileData : CSerializable {
			public Path path;
			public uint spawnMaxPeriod;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				path = s.SerializeObject<Path>(path, name: "path");
				spawnMaxPeriod = s.Serialize<uint>(spawnMaxPeriod, name: "spawnMaxPeriod");
			}
		}
		public override uint? ClassCRC => 0xEF316E08;
	}
}

