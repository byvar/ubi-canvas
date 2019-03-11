using UnityEngine;

namespace UbiArt.ITF {
	public partial class DummyComponent : ActorComponent {
		[Serialize("is2D")] public bool is2D;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(is2D));
			}
		}
		public override uint? ClassCRC => 0xB0493A6E;
	}
}

