namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterControllerComponent : CSerializable {
		[Games(GameFlags.RO)]
		public partial class StateNormal : CSerializable {
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
			}
			public override uint? ClassCRC => 0xC1AA31E2;
		}

		[Games(GameFlags.RO | GameFlags.RL)]
		public partial class StateSpit : CSerializable {
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
			}
			public override uint? ClassCRC => 0x88A15BAC;
		}

		[Games(GameFlags.RO | GameFlags.RL)]
		public partial class StateAttack : CSerializable {
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
			}
			public override uint? ClassCRC => 0x060164BA;
		}

		[Games(GameFlags.RO | GameFlags.RL)]
		public partial class StateBubble : CSerializable {
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
			}
			public override uint? ClassCRC => 0x05D98F0C;
		}

		[Games(GameFlags.RO)]
		public partial class StateHit : CSerializable {
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
			}
			public override uint? ClassCRC => 0x24E7EEE0;
		}

		[Games(GameFlags.RO | GameFlags.RL)]
		public partial class StateSequences : CSerializable {
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
			}
			public override uint? ClassCRC => 0xE9642E27;
		}
	}
}

