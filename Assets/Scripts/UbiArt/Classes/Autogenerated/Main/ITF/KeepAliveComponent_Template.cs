using UnityEngine;

namespace UbiArt.ITF {
	public partial class KeepAliveComponent_Template : ActorComponent_Template {
		[Serialize("startDying"  )] public bool startDying;
		[Serialize("useFade"     )] public bool useFade;
		[Serialize("fadeDuration")] public float fadeDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(startDying));
			} else {
				SerializeField(s, nameof(startDying));
				SerializeField(s, nameof(useFade));
				SerializeField(s, nameof(fadeDuration));
			}
		}
		public override uint? ClassCRC => 0x991810D0;
	}
}

