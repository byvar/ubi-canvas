using UnityEngine;

namespace UbiArt.online {
	public partial class GameGlobalsAlwaysCondition : GameGlobalsCondition {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8E74B909;
	}
}

