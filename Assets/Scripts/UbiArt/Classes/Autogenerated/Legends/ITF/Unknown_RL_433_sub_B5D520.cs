using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_433_sub_B5D520 : CSerializable {
		[Serialize("toctocRumbleName")] public StringID toctocRumbleName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(toctocRumbleName));
		}
		public override uint? ClassCRC => 0xBD94FF75;
	}
}

