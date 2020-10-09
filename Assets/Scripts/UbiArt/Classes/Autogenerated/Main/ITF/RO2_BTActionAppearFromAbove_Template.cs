using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionAppearFromAbove_Template : BTAction_Template {
		public StringID animFloat;
		public StringID animFall;
		public StringID animGround;
		public float groundDistance;
		public float fallDist;
		public float transitionDuration;
		public float transitionGravityFactorMin;
		public float transitionGravityFactorMax;
		public float fallGravityFactor;
		public float floatSpeedMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animFloat = s.SerializeObject<StringID>(animFloat, name: "animFloat");
			animFall = s.SerializeObject<StringID>(animFall, name: "animFall");
			animGround = s.SerializeObject<StringID>(animGround, name: "animGround");
			groundDistance = s.Serialize<float>(groundDistance, name: "groundDistance");
			groundDistance = s.Serialize<float>(groundDistance, name: "groundDistance");
			fallDist = s.Serialize<float>(fallDist, name: "fallDist");
			transitionDuration = s.Serialize<float>(transitionDuration, name: "transitionDuration");
			transitionGravityFactorMin = s.Serialize<float>(transitionGravityFactorMin, name: "transitionGravityFactorMin");
			transitionGravityFactorMax = s.Serialize<float>(transitionGravityFactorMax, name: "transitionGravityFactorMax");
			fallGravityFactor = s.Serialize<float>(fallGravityFactor, name: "fallGravityFactor");
			floatSpeedMax = s.Serialize<float>(floatSpeedMax, name: "floatSpeedMax");
		}
		public override uint? ClassCRC => 0x7C8CAFA7;
	}
}

