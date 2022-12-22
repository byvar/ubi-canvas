namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class GameMaterial_Template : TemplateObj {
		public CListO<StringID> feedbackTags;
		public bool solid = true;
		public uint filter;
		public bool nostim;
		public bool noStick;
		public bool noWalkOnWall;
		public bool noShadow;
		public bool castShadow;
		public float moveSpeed;
		public float moveForce;
		public float friction = 1f;
		public float speedMultiplier = 1f;
		public float regionFriction;
		public float regionFrictionAir;
		public float WaterResistance;
		public uint amount;
		public uint collisionGroup;
		public StringID soundMatGUID;
		public StringID type;
		public uint phys2dFilter = 1;
		public StringID archetype;
		public Nullable<FxKit> fxkit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				type = s.SerializeObject<StringID>(type, name: "type");
				archetype = s.SerializeObject<StringID>(archetype, name: "archetype");
				solid = s.Serialize<bool>(solid, name: "solid");
				nostim = s.Serialize<bool>(nostim, name: "nostim");
				noStick = s.Serialize<bool>(noStick, name: "noStick");
				noWalkOnWall = s.Serialize<bool>(noWalkOnWall, name: "noWalkOnWall");
				noShadow = s.Serialize<bool>(noShadow, name: "noShadow");
				moveSpeed = s.Serialize<float>(moveSpeed, name: "moveSpeed");
				moveForce = s.Serialize<float>(moveForce, name: "moveForce");
				friction = s.Serialize<float>(friction, name: "friction");
				speedMultiplier = s.Serialize<float>(speedMultiplier, name: "speedMultiplier");
				regionFriction = s.Serialize<float>(regionFriction, name: "regionFriction");
				regionFrictionAir = s.Serialize<float>(regionFrictionAir, name: "regionFrictionAir");
				WaterResistance = s.Serialize<float>(WaterResistance, name: "WaterResistance");
				amount = s.Serialize<uint>(amount, name: "amount");
				fxkit = s.SerializeObject<Nullable<FxKit>>(fxkit, name: "fxkit");
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				feedbackTags = s.SerializeObject<CListO<StringID>>(feedbackTags, name: "feedbackTags");
				solid = s.Serialize<bool>(solid, name: "solid");
				nostim = s.Serialize<bool>(nostim, name: "nostim");
				noStick = s.Serialize<bool>(noStick, name: "noStick");
				noWalkOnWall = s.Serialize<bool>(noWalkOnWall, name: "noWalkOnWall");
				noShadow = s.Serialize<bool>(noShadow, name: "noShadow");
				moveSpeed = s.Serialize<float>(moveSpeed, name: "moveSpeed");
				moveForce = s.Serialize<float>(moveForce, name: "moveForce");
				friction = s.Serialize<float>(friction, name: "friction");
				speedMultiplier = s.Serialize<float>(speedMultiplier, name: "speedMultiplier");
				regionFriction = s.Serialize<float>(regionFriction, name: "regionFriction");
				regionFrictionAir = s.Serialize<float>(regionFrictionAir, name: "regionFrictionAir");
				WaterResistance = s.Serialize<float>(WaterResistance, name: "WaterResistance");
				amount = s.Serialize<uint>(amount, name: "amount");
				collisionGroup = s.Serialize<uint>(collisionGroup, name: "collisionGroup");
			} else if (s.Settings.game == Settings.Game.VH) {
				feedbackTags = s.SerializeObject<CListO<StringID>>(feedbackTags, name: "feedbackTags");
				solid = s.Serialize<bool>(solid, name: "solid");
				filter = s.Serialize<uint>(filter, name: "filter");
				nostim = s.Serialize<bool>(nostim, name: "nostim");
				noStick = s.Serialize<bool>(noStick, name: "noStick");
				noWalkOnWall = s.Serialize<bool>(noWalkOnWall, name: "noWalkOnWall");
				noShadow = s.Serialize<bool>(noShadow, name: "noShadow");
				moveSpeed = s.Serialize<float>(moveSpeed, name: "moveSpeed");
				moveForce = s.Serialize<float>(moveForce, name: "moveForce");
				friction = s.Serialize<float>(friction, name: "friction");
				speedMultiplier = s.Serialize<float>(speedMultiplier, name: "speedMultiplier");
				regionFriction = s.Serialize<float>(regionFriction, name: "regionFriction");
				regionFrictionAir = s.Serialize<float>(regionFrictionAir, name: "regionFrictionAir");
				WaterResistance = s.Serialize<float>(WaterResistance, name: "WaterResistance");
				amount = s.Serialize<uint>(amount, name: "amount");
				collisionGroup = s.Serialize<uint>(collisionGroup, name: "collisionGroup");
				soundMatGUID = s.SerializeObject<StringID>(soundMatGUID, name: "soundMatGUID");
			} else {
				feedbackTags = s.SerializeObject<CListO<StringID>>(feedbackTags, name: "feedbackTags");
				solid = s.Serialize<bool>(solid, name: "solid");
				filter = s.Serialize<uint>(filter, name: "filter");
				nostim = s.Serialize<bool>(nostim, name: "nostim");
				noStick = s.Serialize<bool>(noStick, name: "noStick");
				noWalkOnWall = s.Serialize<bool>(noWalkOnWall, name: "noWalkOnWall");
				noShadow = s.Serialize<bool>(noShadow, name: "noShadow");
				castShadow = s.Serialize<bool>(castShadow, name: "castShadow");
				moveSpeed = s.Serialize<float>(moveSpeed, name: "moveSpeed");
				moveForce = s.Serialize<float>(moveForce, name: "moveForce");
				friction = s.Serialize<float>(friction, name: "friction");
				speedMultiplier = s.Serialize<float>(speedMultiplier, name: "speedMultiplier");
				regionFriction = s.Serialize<float>(regionFriction, name: "regionFriction");
				regionFrictionAir = s.Serialize<float>(regionFrictionAir, name: "regionFrictionAir");
				WaterResistance = s.Serialize<float>(WaterResistance, name: "WaterResistance");
				amount = s.Serialize<uint>(amount, name: "amount");
				collisionGroup = s.Serialize<uint>(collisionGroup, name: "collisionGroup");
				soundMatGUID = s.SerializeObject<StringID>(soundMatGUID, name: "soundMatGUID");
				type = s.SerializeObject<StringID>(type, name: "type");
				phys2dFilter = s.Serialize<uint>(phys2dFilter, name: "phys2dFilter");
			}
		}
		public override uint? ClassCRC => 0xE2D3AA9C;
	}
}

