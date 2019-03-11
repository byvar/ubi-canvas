using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionUTurn_Template : BTAction_Template {
		[Serialize("animTurn"    )] public StringID animTurn;
		[Serialize("endAnim"     )] public StringID endAnim;
		[Serialize("useFlipEvent")] public bool useFlipEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(animTurn));
				SerializeField(s, nameof(endAnim));
			} else {
				SerializeField(s, nameof(animTurn));
				SerializeField(s, nameof(endAnim));
				SerializeField(s, nameof(useFlipEvent));
			}
		}
		public override uint? ClassCRC => 0x2601289C;
	}
}

