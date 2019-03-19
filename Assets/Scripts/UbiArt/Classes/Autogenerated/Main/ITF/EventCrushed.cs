using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL)]
	public partial class EventCrushed : Event {
		[Serialize("characterSize"   )] public CHARACTERSIZE characterSize;
		[Serialize("direction"       )] public Vector2 direction;
		[Serialize("fxPos"           )] public Vector3 fxPos;
		[Serialize("bounce"          )] public bool bounce;
		[Serialize("bounceMultiplier")] public float bounceMultiplier;
		[Serialize("characterSize"   )] public Enum_characterSize characterSize;
		[Serialize("sender"          )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(characterSize));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(fxPos));
				SerializeField(s, nameof(bounce));
				SerializeField(s, nameof(bounceMultiplier));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(characterSize));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(fxPos));
				SerializeField(s, nameof(bounce));
				SerializeField(s, nameof(bounceMultiplier));
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
		public enum Enum_characterSize {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_characterSize {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xE465E37F;
	}
}

