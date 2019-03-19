using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BossMorayNodeComponent_Template : CSerializable {
		[Serialize("triggerEvent"      )] public Placeholder triggerEvent;
		[Serialize("debugCorridorWidth")] public float debugCorridorWidth;
		[Serialize("float__0"          )] public float float__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(triggerEvent));
				SerializeField(s, nameof(debugCorridorWidth));
			} else {
				SerializeField(s, nameof(float__0));
			}
		}
		public override uint? ClassCRC => 0x4B2C34EF;
	}
}

