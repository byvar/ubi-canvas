using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class FXControllerComponent : ActorComponent {
		[Serialize("allowBusMixEvents"   )] public bool allowBusMixEvents;
		[Serialize("allowMusicEvents"    )] public bool allowMusicEvents;
		[Serialize("FXCurrentSwitchRules")] public CMap<StringID, StringID> FXCurrentSwitchRules;
		[Serialize("triggerFXisActive"   )] public int triggerFXisActive;
		[Serialize("triggerFx"           )] public StringID triggerFx;
		[Serialize("defaultFx"           )] public StringID defaultFx;
		[Serialize("defaultFxList"       )] public CList<StringID> defaultFxList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerFXisActive));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(triggerFx));
					SerializeField(s, nameof(defaultFx));
					SerializeField(s, nameof(allowBusMixEvents), boolAsByte: true);
					SerializeField(s, nameof(allowMusicEvents), boolAsByte: true);
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(triggerFx));
					SerializeField(s, nameof(defaultFx));
					SerializeField(s, nameof(defaultFxList));
					SerializeField(s, nameof(allowBusMixEvents), boolAsByte: true);
					SerializeField(s, nameof(allowMusicEvents), boolAsByte: true);
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(allowBusMixEvents));
					SerializeField(s, nameof(allowMusicEvents));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(allowBusMixEvents));
					SerializeField(s, nameof(allowMusicEvents));
				}
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(FXCurrentSwitchRules));
				}
			}
		}
		public override uint? ClassCRC => 0x8D4FFFB6;
	}
}

