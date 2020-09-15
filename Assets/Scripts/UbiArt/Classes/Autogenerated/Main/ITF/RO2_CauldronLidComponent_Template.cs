using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CauldronLidComponent_Template : ActorComponent_Template {
		public StringID freeFallAnim;
		public StringID groundReceptionAnim;
		public StringID standAnim;
		public StringID snappedAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			freeFallAnim = s.SerializeObject<StringID>(freeFallAnim, name: "freeFallAnim");
			groundReceptionAnim = s.SerializeObject<StringID>(groundReceptionAnim, name: "groundReceptionAnim");
			standAnim = s.SerializeObject<StringID>(standAnim, name: "standAnim");
			snappedAnim = s.SerializeObject<StringID>(snappedAnim, name: "snappedAnim");
		}
		public override uint? ClassCRC => 0x99BB793A;
	}
}

