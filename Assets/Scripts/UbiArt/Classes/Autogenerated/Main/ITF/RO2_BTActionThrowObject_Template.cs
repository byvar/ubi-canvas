using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionThrowObject_Template : BTAction_Template {
		[Serialize("enemyDetectionRange"       )] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("anim"                      )] public StringID anim;
		[Serialize("markerSpawn"               )] public StringID markerSpawn;
		[Serialize("markerLaunch"              )] public StringID markerLaunch;
		[Serialize("markerStartSpawneeDig"     )] public StringID markerStartSpawneeDig;
		[Serialize("boneSnap"                  )] public StringID boneSnap;
		[Serialize("projectiles"               )] public CList<RO2_BTActionThrowObject_Template.ProjectileData> projectiles;
		[Serialize("launchData"                )] public CList<RO2_BTActionThrowObject_Tools.LaunchData> launchData;
		[Serialize("customPhantomShape"        )] public StringID customPhantomShape;
		[Serialize("customPhantomShapeEventOn" )] public StringID customPhantomShapeEventOn;
		[Serialize("customPhantomShapeEventOff")] public StringID customPhantomShapeEventOff;
		[Serialize("quickLaunchOffset"         )] public Vector2 quickLaunchOffset;
		[Serialize("debug"                     )] public bool debug;
		[Serialize("projectileData"            )] public Placeholder projectileData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(enemyDetectionRange));
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(markerSpawn));
				SerializeField(s, nameof(markerLaunch));
				SerializeField(s, nameof(markerStartSpawneeDig));
				SerializeField(s, nameof(boneSnap));
				SerializeField(s, nameof(projectileData));
				SerializeField(s, nameof(launchData));
				SerializeField(s, nameof(customPhantomShape));
				SerializeField(s, nameof(customPhantomShapeEventOn));
				SerializeField(s, nameof(customPhantomShapeEventOff));
				SerializeField(s, nameof(quickLaunchOffset));
				SerializeField(s, nameof(debug));
			} else {
				SerializeField(s, nameof(enemyDetectionRange));
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(markerSpawn));
				SerializeField(s, nameof(markerLaunch));
				SerializeField(s, nameof(markerStartSpawneeDig));
				SerializeField(s, nameof(boneSnap));
				SerializeField(s, nameof(projectiles));
				SerializeField(s, nameof(launchData));
				SerializeField(s, nameof(customPhantomShape));
				SerializeField(s, nameof(customPhantomShapeEventOn));
				SerializeField(s, nameof(customPhantomShapeEventOff));
				SerializeField(s, nameof(quickLaunchOffset));
				SerializeField(s, nameof(debug));
			}
		}
		[Games(GameFlags.RA)]
		public partial class ProjectileData : CSerializable {
			[Serialize("path"          )] public Path path;
			[Serialize("spawnMaxPeriod")] public uint spawnMaxPeriod;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(path));
				SerializeField(s, nameof(spawnMaxPeriod));
			}
		}
		public override uint? ClassCRC => 0xEF316E08;
	}
}

