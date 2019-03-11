using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CreditsManagerAIComponent_Template : ActorComponent_Template {
		[Serialize("creditsList")] public CList<CreditsLine> creditsList;
		[Serialize("gmatPath"   )] public Path gmatPath;
		[Serialize("isTriggered")] public bool isTriggered;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(creditsList));
			SerializeField(s, nameof(gmatPath));
			SerializeField(s, nameof(isTriggered));
		}
		public override uint? ClassCRC => 0xB0A62194;
	}
}

