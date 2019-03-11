using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventPlayAnimState : Event {
		[Serialize("anim")] public StringID anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
		}
		public override uint? ClassCRC => 0x709FA59F;
	}
}

