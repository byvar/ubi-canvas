namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AISpawnAction_Template : AIAction_Template {
		public Path path;
		public StringID bonePosName;
		public Generic<Event> onSpawnEvent;
		public uint nbSpawns;
		public Vec2d spawnPosOffset;
		public CArrayO<Angle> clampAnglesList;
		public Angle spawnAngleOffset;
		public bool transmitAlwaysActive;
		public uint spawnMinPreAllocModifier;
		public uint spawnMaxPreAllocModifier;
		public bool requestSpawnOnLoad;
		public Angle angleStart;
		public Angle angleStep;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				path = s.SerializeObject<Path>(path, name: "path");
				bonePosName = s.SerializeObject<StringID>(bonePosName, name: "bonePosName");
				onSpawnEvent = s.SerializeObject<Generic<Event>>(onSpawnEvent, name: "onSpawnEvent");
				nbSpawns = s.Serialize<uint>(nbSpawns, name: "nbSpawns");
				angleStart = s.SerializeObject<Angle>(angleStart, name: "angleStart");
				angleStep = s.SerializeObject<Angle>(angleStep, name: "angleStep");
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.VH) {
				path = s.SerializeObject<Path>(path, name: "path");
				bonePosName = s.SerializeObject<StringID>(bonePosName, name: "bonePosName");
				onSpawnEvent = s.SerializeObject<Generic<Event>>(onSpawnEvent, name: "onSpawnEvent");
				nbSpawns = s.Serialize<uint>(nbSpawns, name: "nbSpawns");
				spawnPosOffset = s.SerializeObject<Vec2d>(spawnPosOffset, name: "spawnPosOffset");
				clampAnglesList = s.SerializeObject<CArrayO<Angle>>(clampAnglesList, name: "clampAnglesList");
				spawnAngleOffset = s.SerializeObject<Angle>(spawnAngleOffset, name: "spawnAngleOffset");
				transmitAlwaysActive = s.Serialize<bool>(transmitAlwaysActive, name: "transmitAlwaysActive");
				if (s.Settings.platform != Settings.Platform.Vita) {
					spawnMinPreAllocModifier = s.Serialize<uint>(spawnMinPreAllocModifier, name: "spawnMinPreAllocModifier");
					spawnMaxPreAllocModifier = s.Serialize<uint>(spawnMaxPreAllocModifier, name: "spawnMaxPreAllocModifier");
					requestSpawnOnLoad = s.Serialize<bool>(requestSpawnOnLoad, name: "requestSpawnOnLoad");
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				path = s.SerializeObject<Path>(path, name: "path");
				bonePosName = s.SerializeObject<StringID>(bonePosName, name: "bonePosName");
				onSpawnEvent = s.SerializeObject<Generic<Event>>(onSpawnEvent, name: "onSpawnEvent");
				nbSpawns = s.Serialize<uint>(nbSpawns, name: "nbSpawns");
				spawnPosOffset = s.SerializeObject<Vec2d>(spawnPosOffset, name: "spawnPosOffset");
				spawnAngleOffset = s.SerializeObject<Angle>(spawnAngleOffset, name: "spawnAngleOffset");
				transmitAlwaysActive = s.Serialize<bool>(transmitAlwaysActive, name: "transmitAlwaysActive", options: CSerializerObject.Options.BoolAsByte);
				spawnMinPreAllocModifier = s.Serialize<uint>(spawnMinPreAllocModifier, name: "spawnMinPreAllocModifier");
				spawnMaxPreAllocModifier = s.Serialize<uint>(spawnMaxPreAllocModifier, name: "spawnMaxPreAllocModifier");
				requestSpawnOnLoad = s.Serialize<bool>(requestSpawnOnLoad, name: "requestSpawnOnLoad");
			} else {
				path = s.SerializeObject<Path>(path, name: "path");
				bonePosName = s.SerializeObject<StringID>(bonePosName, name: "bonePosName");
				onSpawnEvent = s.SerializeObject<Generic<Event>>(onSpawnEvent, name: "onSpawnEvent");
				nbSpawns = s.Serialize<uint>(nbSpawns, name: "nbSpawns");
				spawnPosOffset = s.SerializeObject<Vec2d>(spawnPosOffset, name: "spawnPosOffset");
				clampAnglesList = s.SerializeObject<CArrayO<Angle>>(clampAnglesList, name: "clampAnglesList");
				clampAnglesList = s.SerializeObject<CArrayO<Angle>>(clampAnglesList, name: "clampAnglesList");
				spawnAngleOffset = s.SerializeObject<Angle>(spawnAngleOffset, name: "spawnAngleOffset");
				transmitAlwaysActive = s.Serialize<bool>(transmitAlwaysActive, name: "transmitAlwaysActive");
				spawnMinPreAllocModifier = s.Serialize<uint>(spawnMinPreAllocModifier, name: "spawnMinPreAllocModifier");
				spawnMaxPreAllocModifier = s.Serialize<uint>(spawnMaxPreAllocModifier, name: "spawnMaxPreAllocModifier");
				requestSpawnOnLoad = s.Serialize<bool>(requestSpawnOnLoad, name: "requestSpawnOnLoad");
			}
		}
		public override uint? ClassCRC => 0x4143DF33;
	}
}

