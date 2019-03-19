using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ArmComponent_Template : ActorComponent_Template {
		[Serialize("activationLeftAnim" )] public StringID activationLeftAnim;
		[Serialize("activationRightAnim")] public StringID activationRightAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activationLeftAnim));
			SerializeField(s, nameof(activationRightAnim));
		}
		public override uint? ClassCRC => 0xF1177911;
	}
}

