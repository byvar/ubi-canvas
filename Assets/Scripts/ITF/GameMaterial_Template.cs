using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class GameMaterial_Template : BaseObject {
		[Serialize(0, "feedbackTags")] public Container<StringID> feedbackTags;
		[Serialize(1, "solid")] public bool solid;
		[Serialize(2, "filter", game = Settings.Game.RA)] public uint filter;
		[Serialize(3, "nostim")] public bool nostim;
		[Serialize(4, "noStick")] public bool noStick;
		[Serialize(5, "noWalkOnWall")] public bool noWalkOnWall;
		[Serialize(6, "noShadow")] public bool noShadow;
		[Serialize(7, "castShadow", game = Settings.Game.RA)] public bool castShadow;
		[Serialize(8, "moveSpeed")] public float moveSpeed;
		[Serialize(9, "moveForce")] public float moveForce;
		[Serialize(10, "friction")] public float friction;
		[Serialize(11, "speedMultiplier")] public float speedMultiplier;
		[Serialize(12, "regionFriction")] public float regionFriction;
		[Serialize(13, "regionFrictionAir")] public float regionFrictionAir;
		[Serialize(14, "WaterResistance")] public float WaterResistance;
		[Serialize(15, "amount")] public uint amount;
		[Serialize(16, "collisionGroup")] public uint collisionGroup;
		[Serialize(17, "soundMatGUID", game = Settings.Game.RA)] public StringID soundMatGUID;
		[Serialize(18, "type", game = Settings.Game.RA)] public StringID type;
		[Serialize(19, "phys2DFilter", game = Settings.Game.RA)] public uint phys2DFilter;

		public GameMaterial_Template(Reader reader) : base(reader) {
		}
	}
}
