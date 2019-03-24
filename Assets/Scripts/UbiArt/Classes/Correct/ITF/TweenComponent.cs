using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TweenComponent : ActorComponent {
		[Serialize("trigOnCheckPoint"                       )] public bool trigOnCheckPoint;
		[Serialize("instanceTemplate"                       )] public Nullable<TweenComponent_Template> instanceTemplate;
		[Serialize("syncOffset"                             )] public float syncOffset;
		[Serialize("skipInstructionSetSyncOffset"           )] public bool skipInstructionSetSyncOffset;
		[Serialize("autoStart"                              )] public bool autoStart;
		[Serialize("groupIndex"                             )] public uint groupIndex;
		[Serialize("startSet"                               )] public StringID startSet;
		[Serialize("instructionSets"                        )] public CList<TweenComponent.InstructionSet> instructionSets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(syncOffset));
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(startSet), "- None -");
					} else {
						SerializeField(s, nameof(startSet));
					}
					SerializeField(s, nameof(instructionSets));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(trigOnCheckPoint));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(instanceTemplate));
					SerializeField(s, nameof(syncOffset));
					SerializeField(s, nameof(skipInstructionSetSyncOffset), boolAsByte: true);
					SerializeField(s, nameof(autoStart), boolAsByte: true);
					SerializeField(s, nameof(groupIndex));
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(startSet), "- None -");
					} else {
						SerializeField(s, nameof(startSet));
					}
					SerializeField(s, nameof(instructionSets));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(trigOnCheckPoint), boolAsByte: true);
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(syncOffset));
					SerializeField(s, nameof(skipInstructionSetSyncOffset), boolAsByte: true);
					SerializeField(s, nameof(autoStart), boolAsByte: true);
					SerializeField(s, nameof(groupIndex));
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(startSet), "- None -");
					} else {
						SerializeField(s, nameof(startSet));
					}
					SerializeField(s, nameof(instructionSets));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(trigOnCheckPoint));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(instanceTemplate));
					SerializeField(s, nameof(syncOffset));
					SerializeField(s, nameof(skipInstructionSetSyncOffset));
					SerializeField(s, nameof(autoStart));
					SerializeField(s, nameof(groupIndex));
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(startSet), "- None -");
					} else {
						SerializeField(s, nameof(startSet));
					}
					SerializeField(s, nameof(instructionSets));
				}
			}
		}
		[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
		public partial class InstructionSet : CSerializable {
			[Serialize("name"        )] public StringID name;
			[Serialize("instructions")] public CArray<Generic<TweenInstruction>> instructions;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(instructions));
			}
		}
		public override uint? ClassCRC => 0xB5A9E174;
	}
}

