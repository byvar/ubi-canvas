using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class DummyComponent : ActorComponent {
		[Serialize("is2D")] public bool is2D;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RA) {
				SerializeField(s, nameof(is2D));
			}
		}
		public override uint? ClassCRC => 0xB0493A6E;
	}
}

