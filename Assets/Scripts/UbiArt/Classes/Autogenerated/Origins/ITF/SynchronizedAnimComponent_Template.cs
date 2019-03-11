using UnityEngine;

namespace UbiArt.ITF {
	public partial class SynchronizedAnimComponent_Template : CSerializable {
		[Serialize("inactiveAnim")] public StringID inactiveAnim;
		[Serialize("activeAnim"  )] public StringID activeAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inactiveAnim));
			SerializeField(s, nameof(activeAnim));
		}
		public override uint? ClassCRC => 0x6BEF11CB;
	}
}

