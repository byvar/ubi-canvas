using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class FXControllerComponent_Template : ActorComponent_Template {
		public CListO<StringID> feedbackTags;
		public CListO<FXControl> fxControlList;
		public StringID triggerFx;
		public StringID defaultFx;
		public CMap<StringID, FXControllerComponent_Template.sFXSwitch> FXSwitch;
		public Placeholder defaultFxList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				fxControlList = s.SerializeObject<CListO<FXControl>>(fxControlList, name: "fxControlList");
				triggerFx = s.SerializeObject<StringID>(triggerFx, name: "triggerFx");
				defaultFx = s.SerializeObject<StringID>(defaultFx, name: "defaultFx");
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				feedbackTags = s.SerializeObject<CListO<StringID>>(feedbackTags, name: "feedbackTags");
				fxControlList = s.SerializeObject<CListO<FXControl>>(fxControlList, name: "fxControlList");
				triggerFx = s.SerializeObject<StringID>(triggerFx, name: "triggerFx");
				defaultFx = s.SerializeObject<StringID>(defaultFx, name: "defaultFx");
			} else if (Settings.s.game == Settings.Game.COL) {
				feedbackTags = s.SerializeObject<CListO<StringID>>(feedbackTags, name: "feedbackTags");
				triggerFx = s.SerializeObject<StringID>(triggerFx, name: "triggerFx");
				defaultFx = s.SerializeObject<StringID>(defaultFx, name: "defaultFx");
				defaultFxList = s.SerializeObject<Placeholder>(defaultFxList, name: "defaultFxList");
			} else {
				feedbackTags = s.SerializeObject<CListO<StringID>>(feedbackTags, name: "feedbackTags");
				fxControlList = s.SerializeObject<CListO<FXControl>>(fxControlList, name: "fxControlList");
				triggerFx = s.SerializeObject<StringID>(triggerFx, name: "triggerFx");
				defaultFx = s.SerializeObject<StringID>(defaultFx, name: "defaultFx");
				FXSwitch = s.SerializeObject<CMap<StringID, FXControllerComponent_Template.sFXSwitch>>(FXSwitch, name: "FXSwitch");
			}
		}
		[Games(GameFlags.RA)]
		public partial class sFXSwitchRules : CSerializable {
			public StringID KEY;
			public StringID FXout;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				KEY = s.SerializeObject<StringID>(KEY, name: "KEY");
				KEY = s.SerializeObject<StringID>(KEY, name: "KEY");
				FXout = s.SerializeObject<StringID>(FXout, name: "FXout");
			}
		}
		[Games(GameFlags.RA)]
		public partial class sFXSwitch : CSerializable {
			public CListO<FXControllerComponent_Template.sFXSwitchRules> Rules;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Rules = s.SerializeObject<CListO<FXControllerComponent_Template.sFXSwitchRules>>(Rules, name: "Rules");
			}
		}
		public override uint? ClassCRC => 0x0E355C68;
	}
}

