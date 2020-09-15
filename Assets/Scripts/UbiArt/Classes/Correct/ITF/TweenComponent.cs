using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TweenComponent : ActorComponent {
		public bool trigOnCheckPoint;
		public Nullable<TweenComponent_Template> instanceTemplate;
		public float syncOffset;
		public bool skipInstructionSetSyncOffset;
		public bool autoStart;
		public uint groupIndex;
		public StringID startSet;
		public CList<TweenComponent.InstructionSet> instructionSets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(startSet), "- None -");
					} else {
						startSet = s.SerializeObject<StringID>(startSet, name: "startSet");
					}
					instructionSets = s.SerializeObject<CList<TweenComponent.InstructionSet>>(instructionSets, name: "instructionSets");
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					trigOnCheckPoint = s.Serialize<bool>(trigOnCheckPoint, name: "trigOnCheckPoint");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					instanceTemplate = s.SerializeObject<Nullable<TweenComponent_Template>>(instanceTemplate, name: "instanceTemplate");
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					skipInstructionSetSyncOffset = s.Serialize<bool>(skipInstructionSetSyncOffset, name: "skipInstructionSetSyncOffset", options: CSerializerObject.Options.BoolAsByte);
					autoStart = s.Serialize<bool>(autoStart, name: "autoStart", options: CSerializerObject.Options.BoolAsByte);
					groupIndex = s.Serialize<uint>(groupIndex, name: "groupIndex");
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(startSet), "- None -");
					} else {
						startSet = s.SerializeObject<StringID>(startSet, name: "startSet");
					}
					instructionSets = s.SerializeObject<CList<TweenComponent.InstructionSet>>(instructionSets, name: "instructionSets");
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					trigOnCheckPoint = s.Serialize<bool>(trigOnCheckPoint, name: "trigOnCheckPoint", options: CSerializerObject.Options.BoolAsByte);
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					skipInstructionSetSyncOffset = s.Serialize<bool>(skipInstructionSetSyncOffset, name: "skipInstructionSetSyncOffset", options: CSerializerObject.Options.BoolAsByte);
					autoStart = s.Serialize<bool>(autoStart, name: "autoStart", options: CSerializerObject.Options.BoolAsByte);
					groupIndex = s.Serialize<uint>(groupIndex, name: "groupIndex");
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(startSet), "- None -");
					} else {
						startSet = s.SerializeObject<StringID>(startSet, name: "startSet");
					}
					instructionSets = s.SerializeObject<CList<TweenComponent.InstructionSet>>(instructionSets, name: "instructionSets");
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
						SerializeFieldAsChoiceList(s, nameof(startSet), "- None -");
					} else {
						startSet = s.SerializeObject<StringID>(startSet, name: "startSet");
					}
					instructionSets = s.SerializeObject<CList<TweenComponent.InstructionSet>>(instructionSets, name: "instructionSets");
				}
			}
		}
		[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
		public partial class InstructionSet : CSerializable {
			public StringID name;
			public CArray<Generic<TweenInstruction>> instructions;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				name = s.SerializeObject<StringID>(name, name: "name");
				instructions = s.SerializeObject<CArray<Generic<TweenInstruction>>>(instructions, name: "instructions");
			}
		}
		public override uint? ClassCRC => 0xB5A9E174;
	}
}

