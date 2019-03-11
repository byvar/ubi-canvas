using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimGameplayEvent : AnimMarkerEvent {
		[Serialize("value"     )] public bool value;
		[Serialize("valueFloat")] public float valueFloat;
		[Serialize("name"      )] public StringID name;
		[Serialize("posLocal"  )] public Vector2 posLocal;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(posLocal));
				SerializeField(s, nameof(value));
			} else {
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(valueFloat));
			}
		}
		public override uint? ClassCRC => 0xA2242335;
	}
}

