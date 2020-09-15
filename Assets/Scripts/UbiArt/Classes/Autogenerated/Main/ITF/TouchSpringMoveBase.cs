using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class TouchSpringMoveBase : CSerializable {
		public bool elastic;
		public bool reverse;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				elastic = s.Serialize<bool>(elastic, name: "elastic", options: CSerializerObject.Options.BoolAsByte);
				reverse = s.Serialize<bool>(reverse, name: "reverse", options: CSerializerObject.Options.BoolAsByte);
			} else {
				elastic = s.Serialize<bool>(elastic, name: "elastic");
				reverse = s.Serialize<bool>(reverse, name: "reverse");
			}
		}
		public override uint? ClassCRC => 0xE0D1D3C5;
	}
}

