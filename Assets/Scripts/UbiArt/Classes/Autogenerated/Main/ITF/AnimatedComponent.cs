using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimatedComponent : AnimLightComponent {
		[Serialize("DebugAnimTransition")] public bool DebugAnimTransition;
		[Serialize("EventPostComponents")] public CArray<Generic<Event>> EventPostComponents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(DebugAnimTransition));
				SerializeField(s, nameof(EventPostComponents));
			}
		}
		public override uint? ClassCRC => 0x62A12110;
	}
}

