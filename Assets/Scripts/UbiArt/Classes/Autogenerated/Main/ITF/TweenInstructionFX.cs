using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionFX : TweenInstruction {
		[Serialize("name"         )] public StringID name;
		[Serialize("target"       )] public ObjectPath target;
		[Serialize("ObjectPath__0")] public ObjectPath ObjectPath__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(target));
			} else {
				SerializeField(s, nameof(ObjectPath__0));
			}
		}
		public override uint? ClassCRC => 0xCF6AFA8B;
	}
}

