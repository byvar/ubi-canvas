using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayTrajectory_evt : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x53A76BDD;
	}
}

