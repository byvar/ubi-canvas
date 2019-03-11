using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionStayIdle : BTAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3D0A5562;
	}
}

