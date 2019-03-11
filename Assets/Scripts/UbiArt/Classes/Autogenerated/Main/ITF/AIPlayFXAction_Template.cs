using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIPlayFXAction_Template : AIAction_Template {
		[Serialize("fxName")] public StringID fxName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fxName));
		}
		public override uint? ClassCRC => 0xDA3E6266;
	}
}

