using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TeensyRecapComponent : ActorComponent {
		[Serialize("teensies")] public CList<RO2_TeensyRecapComponent.Teensy> teensies;
		[Serialize("level"   )] public StringID level;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(teensies));
				SerializeField(s, nameof(level));
			}
		}
		[Games(GameFlags.RA)]
		public partial class Teensy : CSerializable {
			[Serialize("prisonerVisualType")] public Prisoner prisonerVisualType;
			[Serialize("animVariation"     )] public uint animVariation;
			[Serialize("flip"              )] public bool flip;
			[Serialize("pos"               )] public Vector3 pos;
			[Serialize("scale"             )] public Vector2 scale;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(prisonerVisualType));
				SerializeField(s, nameof(animVariation));
				SerializeField(s, nameof(flip));
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(scale));
			}
			public enum Prisoner {
				[Serialize("Prisoner_Soldier" )] Soldier = 0,
				[Serialize("Prisoner_Baby"    )] Baby = 1,
				[Serialize("Prisoner_Fool"    )] Fool = 2,
				[Serialize("Prisoner_Princess")] Princess = 3,
				[Serialize("Prisoner_Prince"  )] Prince = 4,
				[Serialize("Prisoner_Queen"   )] Queen = 5,
				[Serialize("Prisoner_King"    )] King = 6,
			}
		}
		public override uint? ClassCRC => 0xA00248AB;
	}
}

