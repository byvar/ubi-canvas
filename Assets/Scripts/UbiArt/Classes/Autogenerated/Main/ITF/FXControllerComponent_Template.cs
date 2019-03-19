using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class FXControllerComponent_Template : ActorComponent_Template {
		[Serialize("feedbackTags" )] public CList<StringID> feedbackTags;
		[Serialize("fxControlList")] public CList<FXControl> fxControlList;
		[Serialize("triggerFx"    )] public StringID triggerFx;
		[Serialize("defaultFx"    )] public StringID defaultFx;
		[Serialize("FXSwitch"     )] public CMap<StringID, FXControllerComponent_Template.sFXSwitch> FXSwitch;
		[Serialize("defaultFxList")] public Placeholder defaultFxList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(fxControlList));
				SerializeField(s, nameof(triggerFx));
				SerializeField(s, nameof(defaultFx));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(feedbackTags));
				SerializeField(s, nameof(fxControlList));
				SerializeField(s, nameof(triggerFx));
				SerializeField(s, nameof(defaultFx));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(feedbackTags));
				SerializeField(s, nameof(triggerFx));
				SerializeField(s, nameof(defaultFx));
				SerializeField(s, nameof(defaultFxList));
			} else {
				SerializeField(s, nameof(feedbackTags));
				SerializeField(s, nameof(fxControlList));
				SerializeField(s, nameof(triggerFx));
				SerializeField(s, nameof(defaultFx));
				SerializeField(s, nameof(FXSwitch));
			}
		}
		[Games(GameFlags.RA)]
		public partial class sFXSwitchRules : CSerializable {
			[Serialize("KEY"  )] public StringID KEY;
			[Serialize("FXout")] public StringID FXout;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(KEY));
				SerializeField(s, nameof(KEY));
				SerializeField(s, nameof(FXout));
			}
		}
		[Games(GameFlags.RA)]
		public partial class sFXSwitch : CSerializable {
			[Serialize("Rules")] public CList<FXControllerComponent_Template.sFXSwitchRules> Rules;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Rules));
			}
		}
		public override uint? ClassCRC => 0x0E355C68;
	}
}

