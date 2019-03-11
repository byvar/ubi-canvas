using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_CreditsManagerAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("creditsList")] public Placeholder creditsList;
		[Serialize("gmatPath"   )] public Path gmatPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(creditsList));
			SerializeField(s, nameof(gmatPath));
		}
		public override uint? ClassCRC => 0x94865FFC;
	}
}

