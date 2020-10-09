using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TeensyRecapComponent : ActorComponent {
		public CListO<RO2_TeensyRecapComponent.Teensy> teensies;
		public StringID level;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				teensies = s.SerializeObject<CListO<RO2_TeensyRecapComponent.Teensy>>(teensies, name: "teensies");
				level = s.SerializeObject<StringID>(level, name: "level");
			}
		}
		[Games(GameFlags.RA)]
		public partial class Teensy : CSerializable {
			public Prisoner prisonerVisualType;
			public uint animVariation;
			public bool flip;
			public Vec3d pos;
			public Vec2d scale;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				prisonerVisualType = s.Serialize<Prisoner>(prisonerVisualType, name: "prisonerVisualType");
				animVariation = s.Serialize<uint>(animVariation, name: "animVariation");
				flip = s.Serialize<bool>(flip, name: "flip");
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				scale = s.SerializeObject<Vec2d>(scale, name: "scale");
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

