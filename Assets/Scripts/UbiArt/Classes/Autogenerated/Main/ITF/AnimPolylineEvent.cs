using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimPolylineEvent : AnimMarkerEvent {
		[Serialize("name"    )] public StringID name;
		[Serialize("posLocal")] public Vector2 posLocal;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(posLocal));
			} else {
			}
		}
		public override uint? ClassCRC => 0xF366A28D;
	}
}

