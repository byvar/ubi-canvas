using UnityEngine;

namespace UbiArt.ITF {
	public partial class ScareStim : EventStim {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1DBFF097;
	}
}

