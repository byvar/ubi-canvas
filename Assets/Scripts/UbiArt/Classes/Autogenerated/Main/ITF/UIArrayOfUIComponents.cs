using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIArrayOfUIComponents : UIArrayOfActors {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x59117557;
	}
}

