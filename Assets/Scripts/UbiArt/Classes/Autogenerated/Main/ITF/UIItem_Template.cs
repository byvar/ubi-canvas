using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIItem_Template : UIComponent_Template {
		[Serialize("is2D"               )] public Placeholder is2D;
		[Serialize("is2D"               )] public bool is2D;
		[Serialize("showingFadeDuration")] public float showingFadeDuration;
		[Serialize("hidingFadeDuration" )] public float hidingFadeDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(is2D));
				SerializeField(s, nameof(is2D));
				SerializeField(s, nameof(showingFadeDuration));
				SerializeField(s, nameof(hidingFadeDuration));
			} else {
			}
		}
		public override uint? ClassCRC => 0x56FD7A38;
	}
}

