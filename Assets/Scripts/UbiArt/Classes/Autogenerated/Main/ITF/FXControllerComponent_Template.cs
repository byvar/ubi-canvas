using UnityEngine;

namespace UbiArt.ITF {
	public partial class FXControllerComponent_Template : ActorComponent_Template {
		[Serialize("feedbackTags" )] public CList<StringID> feedbackTags;
		[Serialize("fxControlList")] public CList<FXControl> fxControlList;
		[Serialize("triggerFx"    )] public StringID triggerFx;
		[Serialize("defaultFx"    )] public StringID defaultFx;
		[Serialize("FXSwitch"     )] public CMap<StringID, FXControllerComponent_Template.sFXSwitch> FXSwitch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(fxControlList));
				SerializeField(s, nameof(triggerFx));
				SerializeField(s, nameof(defaultFx));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(feedbackTags));
				SerializeField(s, nameof(fxControlList));
				SerializeField(s, nameof(triggerFx));
				SerializeField(s, nameof(defaultFx));
			} else {
				SerializeField(s, nameof(feedbackTags));
				SerializeField(s, nameof(fxControlList));
				SerializeField(s, nameof(triggerFx));
				SerializeField(s, nameof(defaultFx));
				SerializeField(s, nameof(FXSwitch));
			}
		}
		public partial class sFXSwitchRules : CSerializable {
			[Serialize("KEY"  )] public StringID KEY;
			[Serialize("FXout")] public StringID FXout;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(KEY));
				SerializeField(s, nameof(FXout));
			}
		}
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

