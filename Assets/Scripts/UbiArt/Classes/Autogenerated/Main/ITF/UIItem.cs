using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class UIItem : UIComponent {
		[Serialize("transition"    )] public int transition;
		[Serialize("display"       )] public int display;
		[Serialize("leftComponent" )] public string leftComponent;
		[Serialize("rightComponent")] public string rightComponent;
		[Serialize("upComponent"   )] public string upComponent;
		[Serialize("downComponent" )] public string downComponent;
		[Serialize("displayMask"   )] public Enum_displayMask displayMask;
		[Serialize("screenSpace"   )] public Vector2 screenSpace;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(transition));
					SerializeField(s, nameof(display));
					SerializeField(s, nameof(leftComponent));
					SerializeField(s, nameof(rightComponent));
					SerializeField(s, nameof(upComponent));
					SerializeField(s, nameof(downComponent));
					SerializeField(s, nameof(displayMask));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(screenSpace));
				}
			} else {
			}
		}
		public enum Enum_displayMask {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value__1")] Value__1 = -1,
		}
		public override uint? ClassCRC => 0x45CBEF2C;
	}
}

