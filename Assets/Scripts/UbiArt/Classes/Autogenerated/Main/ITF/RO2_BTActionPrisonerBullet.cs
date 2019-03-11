using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionPrisonerBullet : RO2_BTActionPrisonerPole {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x23ADE850;
	}
}

