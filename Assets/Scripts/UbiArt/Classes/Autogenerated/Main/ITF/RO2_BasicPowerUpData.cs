using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BasicPowerUpData : CSerializable {
		[Serialize("enabled"     )] public bool enabled;
		[Serialize("toAllPlayers")] public bool toAllPlayers;
		[Serialize("index"       )] public uint index;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enabled));
			SerializeField(s, nameof(toAllPlayers));
			SerializeField(s, nameof(index));
		}
		public override uint? ClassCRC => 0xB22D2A8E;
	}
}

