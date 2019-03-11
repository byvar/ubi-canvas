using UnityEngine;

namespace UbiArt.ITF {
	public partial class TouchScreenInputComponent : ShapeComponent {
		[Serialize("viewName")] public string viewName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(viewName));
			}
		}
		public override uint? ClassCRC => 0x8F11DEDF;
	}
}

