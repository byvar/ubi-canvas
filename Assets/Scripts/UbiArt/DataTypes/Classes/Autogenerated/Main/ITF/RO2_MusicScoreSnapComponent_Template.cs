using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MusicScoreSnapComponent_Template : ActorComponent_Template {
		public Vec2d drc_offset;
		public float drc_grabSmoothA;
		public float drc_grabSmoothB;
		public float drc_softCollisionRadius;
		public float drc_softCollisionAcceleration;
		public float drc_softCollisionDeceleration;
		public StringID drc_inputState;
		public StringID drc_inputStretchX;
		public StringID drc_inputStretchY;
		public float drc_inputStretchSmooth;
		public bool drc_useRelativeScreenSpace;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			drc_offset = s.SerializeObject<Vec2d>(drc_offset, name: "drc_offset");
			drc_grabSmoothA = s.Serialize<float>(drc_grabSmoothA, name: "drc_grabSmoothA");
			drc_grabSmoothB = s.Serialize<float>(drc_grabSmoothB, name: "drc_grabSmoothB");
			drc_softCollisionRadius = s.Serialize<float>(drc_softCollisionRadius, name: "drc_softCollisionRadius");
			drc_softCollisionAcceleration = s.Serialize<float>(drc_softCollisionAcceleration, name: "drc_softCollisionAcceleration");
			drc_softCollisionDeceleration = s.Serialize<float>(drc_softCollisionDeceleration, name: "drc_softCollisionDeceleration");
			drc_inputState = s.SerializeObject<StringID>(drc_inputState, name: "drc_inputState");
			drc_inputStretchX = s.SerializeObject<StringID>(drc_inputStretchX, name: "drc_inputStretchX");
			drc_inputStretchY = s.SerializeObject<StringID>(drc_inputStretchY, name: "drc_inputStretchY");
			drc_inputStretchSmooth = s.Serialize<float>(drc_inputStretchSmooth, name: "drc_inputStretchSmooth");
			drc_useRelativeScreenSpace = s.Serialize<bool>(drc_useRelativeScreenSpace, name: "drc_useRelativeScreenSpace");
		}
		public override uint? ClassCRC => 0xCBC0BAEA;
	}
}

