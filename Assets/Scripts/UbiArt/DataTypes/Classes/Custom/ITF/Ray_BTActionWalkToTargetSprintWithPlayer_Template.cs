namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionWalkToTargetSprintWithPlayer_Template : BTActionWalkToTarget_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE10CCC13;
	}
}

