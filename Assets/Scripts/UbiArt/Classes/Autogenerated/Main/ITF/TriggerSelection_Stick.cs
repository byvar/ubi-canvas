using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerSelection_Stick : TriggerSelectionAbstract {
		[Serialize("Self"    )] public bool Self;
		[Serialize("TagName" )] public StringID TagName;
		[Serialize("TagValue")] public uint TagValue;
		[Serialize("bool__0" )] public bool bool__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(bool__0));
			} else {
				SerializeField(s, nameof(Self));
				SerializeField(s, nameof(TagName));
				SerializeField(s, nameof(TagValue));
			}
		}
		public override uint? ClassCRC => 0x3A0A6EFE;
	}
}

