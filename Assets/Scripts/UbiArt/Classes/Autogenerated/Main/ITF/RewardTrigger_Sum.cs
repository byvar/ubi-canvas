using UnityEngine;

namespace UbiArt.ITF {
	public partial class RewardTrigger_Sum : RewardTrigger_Base {
		[Serialize("typeToGet"         )] public StringID typeToGet;
		[Serialize("amountToGet"       )] public uint amountToGet;
		[Serialize("currentSessionOnly")] public bool currentSessionOnly;
		[Serialize("strictlyEqual"     )] public bool strictlyEqual;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(typeToGet));
			SerializeField(s, nameof(amountToGet));
			SerializeField(s, nameof(currentSessionOnly));
			SerializeField(s, nameof(strictlyEqual));
		}
		public override uint? ClassCRC => 0x9ED03AF7;
	}
}

