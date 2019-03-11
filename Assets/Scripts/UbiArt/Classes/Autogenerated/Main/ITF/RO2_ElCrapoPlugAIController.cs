using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ElCrapoPlugAIController : ActorPlugAIController {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF1822B32;
	}
}

