using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventCrushed : Event {
		[Serialize("characterSize"   )] public CHARACTERSIZE characterSize;
		[Serialize("direction"       )] public Vector2 direction;
		[Serialize("fxPos"           )] public Vector3 fxPos;
		[Serialize("bounce"          )] public bool bounce;
		[Serialize("bounceMultiplier")] public float bounceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
			} else {
				SerializeField(s, nameof(characterSize));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(fxPos));
				SerializeField(s, nameof(bounce));
				SerializeField(s, nameof(bounceMultiplier));
			}
		}
		public enum CHARACTERSIZE {
			[Serialize("CHARACTERSIZE_SMALL" )] SMALL = 0,
			[Serialize("CHARACTERSIZE_NORMAL")] NORMAL = 1,
			[Serialize("CHARACTERSIZE_BIG"   )] BIG = 2,
		}
		public override uint? ClassCRC => 0xE465E37F;
	}
}

