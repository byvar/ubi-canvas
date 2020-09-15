using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ArmComponent_Template : ActorComponent_Template {
		public StringID activationLeftAnim;
		public StringID activationRightAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activationLeftAnim = s.SerializeObject<StringID>(activationLeftAnim, name: "activationLeftAnim");
			activationRightAnim = s.SerializeObject<StringID>(activationRightAnim, name: "activationRightAnim");
		}
		public override uint? ClassCRC => 0xF1177911;
	}
}

