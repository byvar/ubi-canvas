namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class TweenComponent : ActorComponent {
		public bool trigOnCheckPoint;
		public Nullable<TweenComponent_Template> instanceTemplate;
		public float syncOffset;
		public bool skipInstructionSetSyncOffset;
		public bool autoStart = true;
		public uint groupIndex = 0xFFFFFFFF;
		public StringID startSet;
		public CListO<TweenComponent.InstructionSet> instructionSets;

		public uint Vita_00 { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					if (s.HasFlags(SerializeFlags.Editor)) {
						startSet = s.SerializeChoiceListObject<StringID>(startSet, name: "startSet", empty: "- None -");
					} else {
						startSet = s.SerializeObject<StringID>(startSet, name: "startSet");
					}
					instructionSets = s.SerializeObject<CListO<TweenComponent.InstructionSet>>(instructionSets, name: "instructionSets");
				}
			} else if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Persistent) || s.Settings.platform == Settings.Platform.Vita) {
					trigOnCheckPoint = s.Serialize<bool>(trigOnCheckPoint, name: "trigOnCheckPoint");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					instanceTemplate = s.SerializeObject<Nullable<TweenComponent_Template>>(instanceTemplate, name: "instanceTemplate");
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					skipInstructionSetSyncOffset = s.Serialize<bool>(skipInstructionSetSyncOffset, name: "skipInstructionSetSyncOffset", options: CSerializerObject.Options.BoolAsByte);
					autoStart = s.Serialize<bool>(autoStart, name: "autoStart", options: CSerializerObject.Options.BoolAsByte);
					groupIndex = s.Serialize<uint>(groupIndex, name: "groupIndex");
					if (s.Settings.platform == Settings.Platform.Vita) {
						Vita_00 = s.Serialize<uint>(Vita_00, name: nameof(Vita_00));
					}
					if (s.HasFlags(SerializeFlags.Editor)) {
						startSet = s.SerializeChoiceListObject<StringID>(startSet, name: "startSet", empty: "- None -");
					} else {
						startSet = s.SerializeObject<StringID>(startSet, name: "startSet");
					}
					instructionSets = s.SerializeObject<CListO<TweenComponent.InstructionSet>>(instructionSets, name: "instructionSets");
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					trigOnCheckPoint = s.Serialize<bool>(trigOnCheckPoint, name: "trigOnCheckPoint", options: CSerializerObject.Options.BoolAsByte);
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					skipInstructionSetSyncOffset = s.Serialize<bool>(skipInstructionSetSyncOffset, name: "skipInstructionSetSyncOffset", options: CSerializerObject.Options.BoolAsByte);
					autoStart = s.Serialize<bool>(autoStart, name: "autoStart", options: CSerializerObject.Options.BoolAsByte);
					groupIndex = s.Serialize<uint>(groupIndex, name: "groupIndex");
					if (s.HasFlags(SerializeFlags.Editor)) {
						startSet = s.SerializeChoiceListObject<StringID>(startSet, name: "startSet", empty: "- None -");
					} else {
						startSet = s.SerializeObject<StringID>(startSet, name: "startSet");
					}
					instructionSets = s.SerializeObject<CListO<TweenComponent.InstructionSet>>(instructionSets, name: "instructionSets");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					trigOnCheckPoint = s.Serialize<bool>(trigOnCheckPoint, name: "trigOnCheckPoint");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					instanceTemplate = s.SerializeObject<Nullable<TweenComponent_Template>>(instanceTemplate, name: "instanceTemplate");
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					skipInstructionSetSyncOffset = s.Serialize<bool>(skipInstructionSetSyncOffset, name: "skipInstructionSetSyncOffset");
					autoStart = s.Serialize<bool>(autoStart, name: "autoStart");
					groupIndex = s.Serialize<uint>(groupIndex, name: "groupIndex");
					if (s.HasFlags(SerializeFlags.Editor)) {
						startSet = s.SerializeChoiceListObject<StringID>(startSet, name: "startSet", empty: "- None -");
					} else {
						startSet = s.SerializeObject<StringID>(startSet, name: "startSet");
					}
					instructionSets = s.SerializeObject<CListO<TweenComponent.InstructionSet>>(instructionSets, name: "instructionSets");
				}
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
		public partial class InstructionSet : CSerializable {
			public StringID name;
			public CArrayO<Generic<TweenInstruction>> instructions;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				name = s.SerializeObject<StringID>(name, name: "name");
				instructions = s.SerializeObject<CArrayO<Generic<TweenInstruction>>>(instructions, name: "instructions");
			}
		}
		public override uint? ClassCRC => 0xB5A9E174;
	}
}

