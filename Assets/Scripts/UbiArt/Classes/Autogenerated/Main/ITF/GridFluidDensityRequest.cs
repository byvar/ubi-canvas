using UnityEngine;

namespace UbiArt.ITF {
	public partial class GridFluidDensityRequest : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB40FB953;
	}
}

