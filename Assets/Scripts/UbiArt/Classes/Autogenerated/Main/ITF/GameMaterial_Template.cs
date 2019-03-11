using UnityEngine;

namespace UbiArt.ITF {
	public partial class GameMaterial_Template : TemplateObj {
		[Serialize("feedbackTags"     )] public CList<StringID> feedbackTags;
		[Serialize("solid"            )] public bool solid;
		[Serialize("filter"           )] public uint filter;
		[Serialize("nostim"           )] public bool nostim;
		[Serialize("noStick"          )] public bool noStick;
		[Serialize("noWalkOnWall"     )] public bool noWalkOnWall;
		[Serialize("noShadow"         )] public bool noShadow;
		[Serialize("castShadow"       )] public bool castShadow;
		[Serialize("moveSpeed"        )] public float moveSpeed;
		[Serialize("moveForce"        )] public float moveForce;
		[Serialize("friction"         )] public float friction;
		[Serialize("speedMultiplier"  )] public float speedMultiplier;
		[Serialize("regionFriction"   )] public float regionFriction;
		[Serialize("regionFrictionAir")] public float regionFrictionAir;
		[Serialize("WaterResistance"  )] public float WaterResistance;
		[Serialize("amount"           )] public uint amount;
		[Serialize("collisionGroup"   )] public uint collisionGroup;
		[Serialize("soundMatGUID"     )] public StringID soundMatGUID;
		[Serialize("type"             )] public StringID type;
		[Serialize("phys2dFilter"     )] public uint phys2dFilter;
		[Serialize("archetype"        )] public StringID archetype;
		[Serialize("fxkit"            )] public Placeholder fxkit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
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
			} else if (Settings.s.game == Settings.Game.RL) {
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

