using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ActivationSequenceTriggerComponent_Template : CSerializable {
		[Serialize("fx"         )] public Path fx;
		[Serialize("fxBone"     )] public StringID fxBone;
		[Serialize("canActivate")] public int canActivate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fx));
			SerializeField(s, nameof(fxBone));
			SerializeField(s, nameof(canActivate));
		}
		public override uint? ClassCRC => 0xF8367EB7;
	}
}

