using UnityEngine;

namespace UbiArt.ITF {
	public partial class VacuumStim : WindStim {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x236122FC;
	}
}

