using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AISpawnAction_Template : AIAction_Template {
		[Serialize("path"                    )] public Path path;
		[Serialize("bonePosName"             )] public StringID bonePosName;
		[Serialize("onSpawnEvent"            )] public Generic<Event> onSpawnEvent;
		[Serialize("nbSpawns"                )] public uint nbSpawns;
		[Serialize("spawnPosOffset"          )] public Vec2d spawnPosOffset;
		[Serialize("clampAnglesList"         )] public CArray<Angle> clampAnglesList;
		[Serialize("spawnAngleOffset"        )] public Angle spawnAngleOffset;
		[Serialize("transmitAlwaysActive"    )] public bool transmitAlwaysActive;
		[Serialize("spawnMinPreAllocModifier")] public uint spawnMinPreAllocModifier;
		[Serialize("spawnMaxPreAllocModifier")] public uint spawnMaxPreAllocModifier;
		[Serialize("requestSpawnOnLoad"      )] public bool requestSpawnOnLoad;
		[Serialize("angleStart"              )] public Angle angleStart;
		[Serialize("angleStep"               )] public Angle angleStep;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(path));
				SerializeField(s, nameof(bonePosName));
				SerializeField(s, nameof(onSpawnEvent));
				SerializeField(s, nameof(nbSpawns));
				SerializeField(s, nameof(angleStart));
				SerializeField(s, nameof(angleStep));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(path));
				SerializeField(s, nameof(bonePosName));
				SerializeField(s, nameof(onSpawnEvent));
				SerializeField(s, nameof(nbSpawns));
				SerializeField(s, nameof(spawnPosOffset));
				SerializeField(s, nameof(clampAnglesList));
				SerializeField(s, nameof(spawnAngleOffset));
				SerializeField(s, nameof(transmitAlwaysActive));
				SerializeField(s, nameof(spawnMinPreAllocModifier));
				SerializeField(s, nameof(spawnMaxPreAllocModifier));
				SerializeField(s, nameof(requestSpawnOnLoad));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(path));
				SerializeField(s, nameof(bonePosName));
				SerializeField(s, nameof(onSpawnEvent));
				SerializeField(s, nameof(nbSpawns));
				SerializeField(s, nameof(spawnPosOffset));
				SerializeField(s, nameof(spawnAngleOffset));
				SerializeField(s, nameof(transmitAlwaysActive), boolAsByte: true);
				SerializeField(s, nameof(spawnMinPreAllocModifier));
				SerializeField(s, nameof(spawnMaxPreAllocModifier));
				SerializeField(s, nameof(requestSpawnOnLoad));
			} else {
				SerializeField(s, nameof(path));
				SerializeField(s, nameof(bonePosName));
				SerializeField(s, nameof(onSpawnEvent));
				SerializeField(s, nameof(nbSpawns));
				SerializeField(s, nameof(spawnPosOffset));
				SerializeField(s, nameof(clampAnglesList));
				SerializeField(s, nameof(clampAnglesList));
				SerializeField(s, nameof(spawnAngleOffset));
				SerializeField(s, nameof(transmitAlwaysActive));
				SerializeField(s, nameof(spawnMinPreAllocModifier));
				SerializeField(s, nameof(spawnMaxPreAllocModifier));
				SerializeField(s, nameof(requestSpawnOnLoad));
			}
		}
		public override uint? ClassCRC => 0x4143DF33;
	}
}

