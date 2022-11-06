using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_RhythmicSequenceComponent : ActorComponent {
		public bool loop;
		public float easeIn;
		public float easeOut;
		public float fadeIn;
		public float transitionTime;
		public float blocTime;
		public uint type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			loop = s.Serialize<bool>(loop, name: "loop");
			easeIn = s.Serialize<float>(easeIn, name: "easeIn");
			easeOut = s.Serialize<float>(easeOut, name: "easeOut");
			fadeIn = s.Serialize<float>(fadeIn, name: "fadeIn");
			transitionTime = s.Serialize<float>(transitionTime, name: "transitionTime");
			blocTime = s.Serialize<float>(blocTime, name: "blocTime");
			type = s.Serialize<uint>(type, name: "type");
		}
		public override uint? ClassCRC => 0x483AFD4E;
	}
}

