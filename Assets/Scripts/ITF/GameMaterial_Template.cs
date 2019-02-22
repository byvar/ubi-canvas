using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class GameMaterial_Template : BaseObject {
		public Container<StringID> feedbackTags;
		public bool solid;
		public uint filter;
		public bool nostim;
		public bool noStick;
		public bool noWalkOnWall;
		public bool noShadow;
		public bool castShadow;
		public float moveSpeed;
		public float moveForce;
		public float friction;
		public float speedMultiplier;
		public float regionFriction;
		public float regionFrictionAir;
		public float WaterResistance;
		public uint amount;
		public uint collisionGroup;
		public StringID soundMatGUID;
		public StringID type;
		public uint phys2DFilter;

		public GameMaterial_Template(Reader reader) : base(reader) {
			feedbackTags = new Container<StringID>(reader);
			solid = reader.ReadBoolean();
			filter = reader.ReadUInt32();
			nostim = reader.ReadBoolean();
			noStick = reader.ReadBoolean();
			noWalkOnWall = reader.ReadBoolean();
			noShadow = reader.ReadBoolean();
			castShadow = reader.ReadBoolean();
			moveSpeed = reader.ReadSingle();
			moveForce = reader.ReadSingle();
			friction = reader.ReadSingle();
			speedMultiplier = reader.ReadSingle();
			regionFriction = reader.ReadSingle();
			regionFrictionAir = reader.ReadSingle();
			WaterResistance = reader.ReadSingle();
			amount = reader.ReadUInt32();
			collisionGroup = reader.ReadUInt32();
			soundMatGUID = new StringID(reader);
			type = new StringID(reader);
			phys2DFilter = reader.ReadUInt32();
		}
	}
}
