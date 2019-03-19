using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class GameMaterial_Template : TemplateObj {
		[Serialize("feedbackTags"       )] public CList<StringID> feedbackTags;
		[Serialize("solid"              )] public bool solid;
		[Serialize("filter"             )] public uint filter;
		[Serialize("nostim"             )] public bool nostim;
		[Serialize("noStick"            )] public bool noStick;
		[Serialize("noWalkOnWall"       )] public bool noWalkOnWall;
		[Serialize("noShadow"           )] public bool noShadow;
		[Serialize("castShadow"         )] public bool castShadow;
		[Serialize("moveSpeed"          )] public float moveSpeed;
		[Serialize("moveForce"          )] public float moveForce;
		[Serialize("friction"           )] public float friction;
		[Serialize("speedMultiplier"    )] public float speedMultiplier;
		[Serialize("regionFriction"     )] public float regionFriction;
		[Serialize("regionFrictionAir"  )] public float regionFrictionAir;
		[Serialize("WaterResistance"    )] public float WaterResistance;
		[Serialize("amount"             )] public uint amount;
		[Serialize("collisionGroup"     )] public uint collisionGroup;
		[Serialize("soundMatGUID"       )] public StringID soundMatGUID;
		[Serialize("type"               )] public StringID type;
		[Serialize("phys2dFilter"       )] public uint phys2dFilter;
		[Serialize("archetype"          )] public StringID archetype;
		[Serialize("fxkit"              )] public Nullable<FxKit> fxkit;
		[Serialize("bool__3"            )] public bool bool__3;
		[Serialize("bool__4"            )] public bool bool__4;
		[Serialize("bool__5"            )] public bool bool__5;
		[Serialize("bool__6"            )] public bool bool__6;
		[Serialize("StringID__16"       )] public StringID StringID__16;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(archetype));
				SerializeField(s, nameof(solid));
				SerializeField(s, nameof(nostim));
				SerializeField(s, nameof(noStick));
				SerializeField(s, nameof(noWalkOnWall));
				SerializeField(s, nameof(noShadow));
				SerializeField(s, nameof(moveSpeed));
				SerializeField(s, nameof(moveForce));
				SerializeField(s, nameof(friction));
				SerializeField(s, nameof(speedMultiplier));
				SerializeField(s, nameof(regionFriction));
				SerializeField(s, nameof(regionFrictionAir));
				SerializeField(s, nameof(WaterResistance));
				SerializeField(s, nameof(amount));
				SerializeField(s, nameof(fxkit));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(feedbackTags));
				SerializeField(s, nameof(solid));
				SerializeField(s, nameof(nostim));
				SerializeField(s, nameof(noStick));
				SerializeField(s, nameof(noWalkOnWall));
				SerializeField(s, nameof(noShadow));
				SerializeField(s, nameof(moveSpeed));
				SerializeField(s, nameof(moveForce));
				SerializeField(s, nameof(friction));
				SerializeField(s, nameof(speedMultiplier));
				SerializeField(s, nameof(regionFriction));
				SerializeField(s, nameof(regionFrictionAir));
				SerializeField(s, nameof(WaterResistance));
				SerializeField(s, nameof(amount));
				SerializeField(s, nameof(collisionGroup));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(feedbackTags));
				SerializeField(s, nameof(solid));
				SerializeField(s, nameof(filter));
				SerializeField(s, nameof(bool__3));
				SerializeField(s, nameof(bool__4));
				SerializeField(s, nameof(bool__5));
				SerializeField(s, nameof(bool__6));
				SerializeField(s, nameof(moveSpeed));
				SerializeField(s, nameof(moveForce));
				SerializeField(s, nameof(friction));
				SerializeField(s, nameof(speedMultiplier));
				SerializeField(s, nameof(regionFriction));
				SerializeField(s, nameof(regionFrictionAir));
				SerializeField(s, nameof(WaterResistance));
				SerializeField(s, nameof(amount));
				SerializeField(s, nameof(collisionGroup));
				SerializeField(s, nameof(StringID__16));
			} else {
				SerializeField(s, nameof(feedbackTags));
				SerializeField(s, nameof(solid));
				SerializeField(s, nameof(filter));
				SerializeField(s, nameof(nostim));
				SerializeField(s, nameof(noStick));
				SerializeField(s, nameof(noWalkOnWall));
				SerializeField(s, nameof(noShadow));
				SerializeField(s, nameof(castShadow));
				SerializeField(s, nameof(moveSpeed));
				SerializeField(s, nameof(moveForce));
				SerializeField(s, nameof(friction));
				SerializeField(s, nameof(speedMultiplier));
				SerializeField(s, nameof(regionFriction));
				SerializeField(s, nameof(regionFrictionAir));
				SerializeField(s, nameof(WaterResistance));
				SerializeField(s, nameof(amount));
				SerializeField(s, nameof(collisionGroup));
				SerializeField(s, nameof(soundMatGUID));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(phys2dFilter));
			}
		}
		public override uint? ClassCRC => 0xE2D3AA9C;
	}
}

