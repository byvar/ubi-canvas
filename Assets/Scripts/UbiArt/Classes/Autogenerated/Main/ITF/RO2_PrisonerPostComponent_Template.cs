using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PrisonerPostComponent_Template : RO2_AIComponent_Template {
		[Serialize("animIdle"        )] public StringID animIdle;
		[Serialize("animExplodeLeft" )] public StringID animExplodeLeft;
		[Serialize("animExplodeRight")] public StringID animExplodeRight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animIdle));
			SerializeField(s, nameof(animExplodeLeft));
			SerializeField(s, nameof(animExplodeRight));
		}
		public override uint? ClassCRC => 0x0A0000CA;
	}
}

