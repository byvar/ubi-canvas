using System;
namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIMedalBehavior : AIBehavior {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			s.Context?.SystemLogger.LogError(s.CurrentPointer + ": Encountered AIMedalBehavior");
			throw new Exception(s.CurrentPointer + ": Encountered AIMedalBehavior");
		}
		public override uint? ClassCRC => 0x402E8012;
	}
}

