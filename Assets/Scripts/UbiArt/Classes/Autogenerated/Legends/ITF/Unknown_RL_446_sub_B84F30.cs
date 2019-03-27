using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_446_sub_B84F30 : ActorComponent {
		[Serialize("camModifier" )] public Unknown_RL_38748_sub_A04420 camModifier;
		[Serialize("transitionIN")] public Unknown_RL_38759_sub_A04790 transitionIN;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(camModifier));
			SerializeField(s, nameof(transitionIN));
		}
		public override uint? ClassCRC => 0x476DE974;
	}
}

