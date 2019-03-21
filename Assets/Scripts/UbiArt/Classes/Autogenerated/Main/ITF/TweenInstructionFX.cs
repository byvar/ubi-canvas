using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionFX : TweenInstruction {
		[Serialize("target"       )] public ObjectPath target;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(target));
		}
		public override uint? ClassCRC => 0xCF6AFA8B;
	}
}

