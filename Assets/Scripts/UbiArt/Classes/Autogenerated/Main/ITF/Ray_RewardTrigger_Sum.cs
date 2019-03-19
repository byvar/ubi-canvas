using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_RewardTrigger_Sum : CSerializable {
		[Serialize("typeToGet"         )] public StringID typeToGet;
		[Serialize("amountToGet"       )] public uint amountToGet;
		[Serialize("currentSessionOnly")] public int currentSessionOnly;
		[Serialize("strictlyEqual"     )] public int strictlyEqual;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(typeToGet));
			SerializeField(s, nameof(amountToGet));
			SerializeField(s, nameof(currentSessionOnly));
			SerializeField(s, nameof(strictlyEqual));
		}
		public override uint? ClassCRC => 0x42FFDF60;
	}
}

