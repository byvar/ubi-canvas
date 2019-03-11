using UnityEngine;

namespace UbiArt.ITF {
	public partial class Trajectory : Pickable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5921DA17;
	}
}

