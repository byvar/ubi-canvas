using UnityEngine;

namespace UbiArt.ITF {
	public partial class ArenaDoorComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6050C40D;
	}
}

