using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicScoreSnapComponent_Template : ActorComponent_Template {
		[Serialize("drc_offset"                   )] public Vector2 drc_offset;
		[Serialize("drc_grabSmoothA"              )] public float drc_grabSmoothA;
		[Serialize("drc_grabSmoothB"              )] public float drc_grabSmoothB;
		[Serialize("drc_softCollisionRadius"      )] public float drc_softCollisionRadius;
		[Serialize("drc_softCollisionAcceleration")] public float drc_softCollisionAcceleration;
		[Serialize("drc_softCollisionDeceleration")] public float drc_softCollisionDeceleration;
		[Serialize("drc_inputState"               )] public StringID drc_inputState;
		[Serialize("drc_inputStretchX"            )] public StringID drc_inputStretchX;
		[Serialize("drc_inputStretchY"            )] public StringID drc_inputStretchY;
		[Serialize("drc_inputStretchSmooth"       )] public float drc_inputStretchSmooth;
		[Serialize("drc_useRelativeScreenSpace"   )] public bool drc_useRelativeScreenSpace;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(drc_offset));
			SerializeField(s, nameof(drc_grabSmoothA));
			SerializeField(s, nameof(drc_grabSmoothB));
			SerializeField(s, nameof(drc_softCollisionRadius));
			SerializeField(s, nameof(drc_softCollisionAcceleration));
			SerializeField(s, nameof(drc_softCollisionDeceleration));
			SerializeField(s, nameof(drc_inputState));
			SerializeField(s, nameof(drc_inputStretchX));
			SerializeField(s, nameof(drc_inputStretchY));
			SerializeField(s, nameof(drc_inputStretchSmooth));
			SerializeField(s, nameof(drc_useRelativeScreenSpace));
		}
		public override uint? ClassCRC => 0xCBC0BAEA;
	}
}

