using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Mission_Template : CSerializable {
		[Serialize("onAvailableActions")] public Placeholder onAvailableActions;
		[Serialize("introSteps"        )] public Placeholder introSteps;
		[Serialize("bodySteps"         )] public Placeholder bodySteps;
		[Serialize("cheatLocation"     )] public StringID cheatLocation;
		[Serialize("sendTracking"      )] public bool sendTracking;
		[Serialize("dlcPackage"        )] public string dlcPackage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(onAvailableActions));
			SerializeField(s, nameof(introSteps));
			SerializeField(s, nameof(bodySteps));
			SerializeField(s, nameof(cheatLocation));
			SerializeField(s, nameof(sendTracking), boolAsByte: true);
			SerializeField(s, nameof(dlcPackage));
		}
		public override uint? ClassCRC => 0x8F80C479;
	}
}

