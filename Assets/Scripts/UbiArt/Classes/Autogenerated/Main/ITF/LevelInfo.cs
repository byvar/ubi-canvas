using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class LevelInfo : CSerializable {
		[Serialize("BasicString__0"            )] public BasicString BasicString__0;
		[Serialize("BasicString__1"            )] public BasicString BasicString__1;
		[Serialize("uint__2"                   )] public uint uint__2;
		[Serialize("RJR_PowerUp__3"            )] public RJR_PowerUp RJR_PowerUp__3;
		[Serialize("BasicString__4"            )] public BasicString BasicString__4;
		[Serialize("BasicString__5"            )] public BasicString BasicString__5;
		[Serialize("uint__6"                   )] public uint uint__6;
		[Serialize("RJR_PowerUp__7"            )] public RJR_PowerUp RJR_PowerUp__7;
		[Serialize("uint__8"                   )] public uint uint__8;
		[Serialize("Gadgets__9"                )] public Gadgets Gadgets__9;
		[Serialize("CList<UnlockedGadgets>__10")] public CList<UnlockedGadgets> CList_UnlockedGadgets__10;
		[Serialize("Gadgets__11"               )] public Gadgets Gadgets__11;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(BasicString__4));
				SerializeField(s, nameof(BasicString__5));
				SerializeField(s, nameof(uint__6));
				SerializeField(s, nameof(RJR_PowerUp__7));
				SerializeField(s, nameof(uint__8));
				SerializeField(s, nameof(Gadgets__9));
				SerializeField(s, nameof(CList_UnlockedGadgets__10));
				SerializeField(s, nameof(Gadgets__11));
			} else {
				SerializeField(s, nameof(BasicString__0));
				SerializeField(s, nameof(BasicString__1));
				SerializeField(s, nameof(uint__2));
				SerializeField(s, nameof(RJR_PowerUp__3));
			}
		}
	}
}

