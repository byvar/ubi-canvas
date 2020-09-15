using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class CameraNearFarFadeComponent_Template : ActorComponent_Template {
		public StringID inputInterp;
		public StringID inputNear;
		public StringID inputFar;
		public StringID inputFadeRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inputInterp = s.SerializeObject<StringID>(inputInterp, name: "inputInterp");
			inputNear = s.SerializeObject<StringID>(inputNear, name: "inputNear");
			inputFar = s.SerializeObject<StringID>(inputFar, name: "inputFar");
			inputFadeRange = s.SerializeObject<StringID>(inputFadeRange, name: "inputFadeRange");
		}
		public override uint? ClassCRC => 0x51381046;
	}
}

